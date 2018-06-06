using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }


        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);


        }


    }

}

//YOU WOULDN'T INHERIT DECK HERE BECUASE INHARITANCE IS A 'IS A' RELATIONSHIP, NOT A 'HAS A' RELATIONSHIP. TWENTYONE IS A GAME A DEALER HAS A DECK.

    //SO INSTEAD ITS A CLASS PROPERTY
    //AIR ON THE SIDE OF PROPERTIES 