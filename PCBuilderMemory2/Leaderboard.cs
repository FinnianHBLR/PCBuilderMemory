using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace PCBuilderMemory2
{
    class Leaderboard
    {
        //Properties
        //Creates a list for MaxItems
        private int maxItems;
        private List<Item> items;
        private ListBox listBox;

        //Constructors 
        public Leaderboard(ListBox listBox, int maxItems)
        {
            this.maxItems = maxItems;
            this.listBox = listBox;
            this.items = new List<Item>(this.maxItems);
            this.load();
        }


        public void load() //Loads the score data from the JSON file.
        {
            try
            {
                using (StreamReader sr = new StreamReader("leaderboard.json"))
                {
                    string rawFile = sr.ReadToEnd();
                    List<Item> loadedItems = JsonConvert.DeserializeObject<List<Item>>(rawFile);
                    this.items = loadedItems;
                    this.sort();
                }
            }
            catch (Exception e)
            {
                //IF the load fails error message will be sent to console.
                Console.WriteLine("[WARN] Failed to load save file.");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public void save()  //Save to JSON file.
        {
            try
            {
                using (StreamWriter sr = new StreamWriter("leaderboard.json"))
                {
                    string rawFile = JsonConvert.SerializeObject(this.items);
                    sr.Write(rawFile);
                }
            }
            catch (Exception e) //If save fails error is written to console.
            {
                Console.WriteLine("[WARN] Failed to store save file.");
                Console.Error.WriteLine(e.StackTrace);
            }
            Console.WriteLine("SAVE");
        }

        public void sort()  //This sorts high score from highest to lowest.
        {
            Console.WriteLine("SORT1");
            var comparer = new ItemComparer();
            this.items.Sort(comparer);
            Console.WriteLine("SORT");
            this.update();
        }

        public void update()    //This updates the listview with new data.
        {
            if (this.listBox == null) return; // ignore if listbox isnt initilized
            this.listBox.Items.Clear();
            this.items.ForEach((item) =>
            {   //For each item add time and name
                this.listBox.Items.Add($"{item.Name} - {this.formatTime(item.Time)}");
            });
            Console.WriteLine("UPDATE");
            //Log in console.
        }

        private string formatTime(int time) //formats time from seconds to minutes and adds ":"
        {
            int minutes = (time / 60);
            string output = "";
            if (minutes != 0)
            {
                output += minutes + ":";
            }
            if (time - (minutes * 60) < 10) output += "0";
            output += (time - (minutes * 60));

            return output;
        }

        public void AddItem(Item item)  //Adds items to list. This also sorts and saves.
        {
            if (this.items.Count < maxItems)
            {
                this.items.Add(item);
                this.sort();
                this.save();
                return;
            }
            if (this.isTopPlayer(item))
            {
                this.removeLast();
                this.items.Add(item);
                this.sort();
                this.save();
                Console.WriteLine("FINISH ADD CALL");
            } //NOTE: A try catch could be implemented here if there was no data to load and caused an error
        }

        private void removeLast()   //If someone has a better time and this function will take that time off the bottom of the list.
        {
            if (this.items.Count == maxItems)
            {
                this.items.RemoveAt(maxItems);
            }
        }

        //Check if a player would be on the leaderboard. 
        private bool isTopPlayer(Item item)
        {
            Console.WriteLine(this.items.Count < this.maxItems);
            if (this.items.Count < this.maxItems) return true;
            List<Item> tempList = new List<Item>();
            this.items.ForEach((i) => tempList.Add(i));
            tempList.Add(item);

            var comparer = new ItemComparer();
            tempList.Sort(comparer);

            return tempList.IndexOf(item) <= maxItems;
        }
    }


    public class ItemComparer : IComparer<Item> //This compares two items
    {
        public int Compare(Item x, Item y)
        {
            if (x == null || y == null) return 0;
            return x.Time.CompareTo(y.Time);
        }
    }

    public class Item   //Constructor and properties for player.
    {
        public string Name;
        public int Time;

        public Item(string name, int score)
        {
            this.Name = name;
            this.Time = score;
        }
    }
}
