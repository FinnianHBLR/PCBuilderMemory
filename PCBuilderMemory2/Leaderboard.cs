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

        private int maxItems;
        private List<Item> items;
        private ListBox listBox;

        public Leaderboard(ListBox listBox, int maxItems) 
        {
            this.maxItems = maxItems;
            this.listBox = listBox;
            this.items = new List<Item>(this.maxItems);
            this.load();
        }
        

        public void load()
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
            } catch (Exception e)
            {
                Console.WriteLine("[WARN] Failed to load save file.");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        public void save()
        {
            try
            {
                using (StreamWriter sr = new StreamWriter("leaderboard.json"))
                {
                    string rawFile = JsonConvert.SerializeObject(this.items);
                    sr.Write(rawFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("[WARN] Failed to store save file.");
                Console.Error.WriteLine(e.StackTrace);
            }
            Console.WriteLine("SAVE");
        }

        public void sort()
        {
            Console.WriteLine("SORT1");
            var comparer = new ItemComparer();
            this.items.Sort(comparer);
            Console.WriteLine("SORT");
            this.update();
        }

        public void update()
        {
            if (this.listBox == null) return; // ignore if listbox isnt initilized
            this.listBox.Items.Clear();
            this.items.ForEach((item) => {
                this.listBox.Items.Add($"{item.Name} - {this.formatTime(item.Time)}");
            });
            Console.WriteLine("UPDATE");

        }

        private string formatTime(int time)
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

        public void AddItem(Item item)
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
            }
        }

        private void removeLast()
        {
            if(this.items.Count == maxItems)
            {
                this.items.RemoveAt(maxItems);
            }
        }

        // check it a player would be on the leaderboard
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


    public class ItemComparer : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            if (x == null || y == null) return 0;
            return x.Time.CompareTo(y.Time);
        }
    }

    public class Item
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
