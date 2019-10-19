using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilderMemory
{
    class Deck
    {
        //Properties
        private List<PartCard> deck = new List<PartCard>();

        //Constructors

        //Create New List of 20 Cards

        //Methods
        public void add(PartCard card)
        {
            this.deck.Add(card);
        }

        public void remove(PartCard part)
        {
            foreach (PartCard partCard in deck)
            {
                if (part.getName() == part.getName())
                {
                    this.deck.Remove(partCard);
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
