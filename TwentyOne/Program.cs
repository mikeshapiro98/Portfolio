using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            //WELCOME MESSAGE
            Console.WriteLine("Hello! Welcome to the Grand Hotel and Casino. Let's start by telling me your name cowboy");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Excellent {0}! Would you like to play a game right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "okay" || answer == "sure" || answer == "ya")
            {

                Player player = new Player(playerName, bank);   //CONSTRUCTOR
                Game game = new TwentyOneGame();       //POLYMORPHISM
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {

                    game.Play();

                }

                game -= player;
                Console.WriteLine("Thanks for playing cowboy.");


            }


            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();


            
        }

    }

}








//NOTES ON LAMDA EXPRESSIONS
//1. This helps to shorten certain tasks like incrementation.
//2. Saves time.
//3. Format "x" in the above example could be anything. You can give it whatever title you'd like. 
//4. => is a distinct lamda expression that that essentially means to evaluate this to each item.
//5. They are very hard to debug compared to say a for loop. You can't go line by line through a Lambda expression. Especially when chaining them together.
//6. It can also make it hard to read. 



//NOTES ON STRUCTS 
//1. Every data type in C# is either a refernce type or a value type.
//2. Think of if you submitted an essay to your teacher and instead of turning it in, you put it on Google Drive so that when she made changes you could see it too. It's a solo address with 2 manipulators. It's the same document even though it seems different. 
//3. Any data type that stores value by referance is a referance data type. This includes all classes.
//4. In the example in number 2 the copy of the assignment vs. putting it on Google Drive would be a value type not a referance type.
//5. Structs are essentially classes except it's a value type rather than a referance type.
//6. Structs CANT be inherited.
//7. Value types cannot have a value of null because it is not a value

//REFERANCE TYPE:
//string
//card
//list


//VALUE TYPES: 
//int
//bool
//enums
//datetime

//NOTES THAT HAVE BEEN DELETED FROM PROGRAM


//Deck deck = new Deck();

////deck.Shuffle(3);


////foreach (Card card in deck.Cards)
////{
////    Console.WriteLine(card.Face + " of " + card.Suit);

////}
////Console.WriteLine(deck.Cards.Count);
//Console.ReadLine();



// int count = deck.Cards.Count(x => x.Face == Face.Ace);     //LAMDA EXPRESSION EXAMPLE   X represents elements and could be called anything
//Think of this as count the elements of x if Face == Ace.
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//this line should create a new list of just kings.
//   Where allows you to filter lists for specific things within it.    

//List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };
//int sum = numberList.Sum(x => x + 5); //Same as sum + 5 for every number in the list (foreach (item in list  add 5))

//int sum = numberList.Max(); //Gets the highest number in the list
//int sum = numberList.Min(); // Gets the lowest number in the list.
//  are you getting the picture as to why this is easier?
//int sum = numberList.Where(X => X > 20).Sum(); //This says to creat a new list if the numbers in the referance list are over 20 and then add the sums together. 
//where creats a new lsit. //USING LAMDA EXPRESSION TO CONCATINATE METHODS TOGETHER.
//Console.WriteLine(sum);
//foreach (Card card in numberList)
//{ 
//    Console.WriteLine(Card.Face);
//}  




//Card Card1 = new Card(); //THIS EXEMPLIFYS STRUCT. It didn't make a new card when it was assigned to card 2 it only chaged its name. It's the same block of memory. this gives card 2 the address of card 1. 
//Card Card2 = Card1;
//Card1.Face = Face.Eight;
//            Card2.Face = Face.King; //This wouldn't work with a string because a string is immutable so can;t be changed. Only recreated.  
//            //AFTER MAKING THE CARD CLASS A STRUCT, the value changed from King to Eight because the struct is a value. Card 1 and card 2 are now completely seperate. 

//            Console.WriteLine(Card2.Face);



//Card card = new Card();
//card.Suit = Suit.Clubs;
//int underlyingValue = (int)Suit.Diamonds; //COULD JUST AS EASILY DO CONVERT.TOINT32 (SUIT.DIAMONDS);
//Console.WriteLine(underlyingValue);



//Player<Card> player = new Player<Card>();
//player.Hand = new List<Card>();


//Game game = new TwentyOneGame();
//game.Players = new List<Player>();
//            Player player = new Player();
//player.Name = "Jesse";
//            game += player;  //game = game + player;
//            game -= player; //game = game - player;




//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
//game.ListPlayers();
//Console.ReadLine();

//ABSTRACT CLASSES NOTES
//Abstract essentially means that the class cannot ever be instantiated. It can only be inherited from.
//Game game = new Game(); //THIS CANNOT BE DONE BECAUSE GAME IS NOW ABSTRACT


//POLYMORPHISM NOTES 
//List<Game> games = new List<Game>();
//Game game = new TwentyOneGame(); //THIS IS POLYMORPHISM!
//games.Add(game);
//THIS IS USEFUL FOR IT THERE WERE MULTIPLE GAMES 
// PokerGame
// SolitaireGame 
// IMAGINE PUTTING ALL OF THE GAMES IN A LIST. 
// A LIST CAN ONLY TAKE ONE DATA TYPE. THIS ALLOWS FOR ALL OF THE GAMES TO BE LISTED AS "GAMES"
// FOR EXAMPLE:
// List<Game> games = new List<Game>();
// Game game = new TwentyOneGame();
// games.Add(game); 
// POLYMORPHISM IS THE ABILITY OF A CLASS TO MORPH INTO ITS INHERITING CLASS WHICH GIVES CERTAIN ADVANTAGES.


// Card card = new Card() { Face = "King", Suit = "Spades" }; ANOTHER WAY TO INTIALIZE A CLASS WITH A ASSIGNED VALUE

//TwentyOneGame game = new TwentyOneGame();
//game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
//game.ListPlayers();
//game.Play();
//Console.ReadLine();
//WHEN YOU CALL FOR A METHOD FROM A CLASS THAT YOU'RE INHERITING FROM, IT IS CALLED A SUPER CLASS METHOD.



//Game game = new Game();
//game.Dealer = "Jesse";
//game.Name = "TwentyOne";



//int timesShuffled = 0;
// deck = Shuffle(deck);
// deck = Shuffle(deck: deck, times: 3); //deck: and times: are optional for readability
//deck = Shuffle(deck, out timesShuffled, 3);

//Console.WriteLine("Times Shuffled: {0}", timesShuffled);

//Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
//Console.WriteLine(deck.Cards[1].Face + " of " + deck.Cards[1].Suit);
//Console.WriteLine(deck.Cards[2].Face + " of " + deck.Cards[2].Suit);
//Console.WriteLine(deck.Cards[3].Face + " of " + deck.Cards[3].Suit);
//Console.WriteLine(deck.Cards[4].Face + " of " + deck.Cards[4].Suit);
//Console.WriteLine(deck.Cards[5].Face + " of " + deck.Cards[5].Suit);
//Console.WriteLine(deck.Cards[6].Face + " of " + deck.Cards[6].Suit);
//Console.WriteLine(deck.Cards[7].Face + " of " + deck.Cards[7].Suit);



//deck.Cards = new List<Card>();



//Card cardOne = new Card();
//cardOne.Face = "Queen";
//cardOne.Suit = "Spades";

//deck.Cards.Add(cardOne);

//Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);



//public static Deck Shuffle(Deck deck, int times)
//{

//    for (int i =0; i<times; i++)
//    {
//        deck = Shuffle(deck);

//    }
//    return deck;

//}