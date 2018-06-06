using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{

    public struct Card
    {

      
        public Suit Suit { get; set; }
        public Face Face { get; set; }

    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades 
            //assigning numbers can help with comparisons thing low, med, high, numbers can be asigned. 
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }



}


//NOTES ON ENUMS
//Can be used to limit the amount of options a user can you you. 
//Assigned as a data type which dictates what the data type can be.
//If you assign a element to an enum it cam be used in say a drop down menu. 
//Eliminates user input errors because it forces the value you want it to the data type. 
//Another benefit is that it uses intellisence to show you the options of what you can assign. This makes the programming eaiser 
//Enums have an underlaying data type. For example: SUIT: SPADES is technically a string.
//In theory you could convert a suit in this situation to an integer. It would assign it it's index number by default, but you can also asign it, its own number. 


//public Card()
//{

//    Suit = "Spades";
//    Face = "Two";
//}
