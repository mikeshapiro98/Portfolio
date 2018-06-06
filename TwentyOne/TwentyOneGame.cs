using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class TwentyOneGame : Game, IWalkAway  //THIS NEEDS TO EMPLOY THE ABSTACT METHOD //A class can only inherit from ONE other class. Otherwise you must use a class and an interface.
    {


        public TwentyOneDealer Dealer { get; set;  }

        public override void Play() //MUST BE IMPLIMENTED SINCE IT'S INHERITING FROM AN ABSTRACT CLASS. 
        {

            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {

                player.Hand = new List<Card>();
                player.Stay = false; 

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach(Player player in Players)
            {

                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)  //SAME AS IF SUCCESSFULLYBET == FALSE.
                {
                     return;
                }
                Bets[player] = bet; //Player is the key here, bet is the value.

            }
            for (int i =0 ; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {            

                                   

                    }

                }


            }

            
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();

        }

    }
}

//Dictionary is a data type containing a collection of key value pairs
////To check for BlackJack we're going to need to get the value of a hand. We also need to know the value of each card. 
//// A layer is simply a class that exists outside of the other classes. The other classes have now knowledge of it. We are making a business logic layer called 21 rules.