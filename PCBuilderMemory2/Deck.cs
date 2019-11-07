using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PCBuilderMemory2
{
    class Deck
    {
        //Properties
        static List<PartCard> deck = new List<PartCard>();


        //Constructors
        public Deck()
        {
            //Creates new list of cards 
            deck = new List<PartCard>
            {
            new PartCard("1", false, false, "CPU", Properties.Resources.cpu),
            new PartCard("2", false, false, "COOLING", Properties.Resources.cooling),
            new PartCard("3", false, false, "MOTHERBOARD", Properties.Resources.motherboard),
            new PartCard("4", false, false, "MEMORY", Properties.Resources.ram),
            new PartCard("5", false, false, "GPU", Properties.Resources.gpu),
            new PartCard("6", false, false, "CASE", Properties.Resources._case),
            new PartCard("7", false, false, "PSU", Properties.Resources.psu),
            new PartCard("8", false, false, "OS", Properties.Resources.os),
            new PartCard("9", false, false, "NETWORK", Properties.Resources.network),
            new PartCard("10", false, false, "STORAGE", Properties.Resources.ssd),

            new PartCard("1", false, false, "CPU", Properties.Resources.cpu),
            new PartCard("2", false, false, "COOLING", Properties.Resources.cooling),
            new PartCard("3", false, false, "MOTHERBOARD", Properties.Resources.motherboard),
            new PartCard("4", false, false, "MEMORY", Properties.Resources.ram),
            new PartCard("5", false, false, "GPU", Properties.Resources.gpu),
            new PartCard("6", false, false, "CASE", Properties.Resources._case),
            new PartCard("7", false, false, "PSU", Properties.Resources.psu),
            new PartCard("8", false, false, "OS", Properties.Resources.os),
            new PartCard("9", false, false, "NETWORK", Properties.Resources.network),
            new PartCard("10", false, false, "STORAGE", Properties.Resources.ssd),

            };
            shuffle();
        }


        //Create New List of 10 Cards

        public List<PartCard> GetPartCards()
        {
            //Returns the entire Deck
            return deck;
        }


        //Methods
        public void add(PartCard card)
        {
            //Adds card to deck
            deck.Add(card);
        }

        public void remove(PartCard part)
        {
            //Removes card from deck
            foreach (PartCard partCard in deck)
            {
                if (part.getName() == part.getName())
                {
                    deck.Remove(partCard);
                }
            }
        }

        public void shuffle()
        {
            Random rand = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                //Select a random card
                int j = rand.Next(i + 1); //Generate a random number between 0 ... i Next is a method to generate a number between i + 1
                //NOTE: rand.next(6) generates a random number between 0 ... 5
                //Swap the first card and the second card

                //Seletcs a j and an i then swaps them
                PartCard temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

        }

    }
}
