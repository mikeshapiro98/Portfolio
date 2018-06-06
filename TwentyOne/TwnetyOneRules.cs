using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwnetyOneRules
    {

        //FIRST WE WILL MAKE A PRIVATE DICTIONARY OF CARD VALUES
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {

            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1  //Can't asign this 2 values, but will do logic later to give this a second value. 


        };

        public static int[] GetAllPossibleHandValues (List<Card> Hand)
        {

            int aceCount = Hand.Count(x => x.Face == Face.Ace);  //Lamda expressions are methods you can perform on lists.
            int[] result = new int[aceCount + 1];   // Remember with an array you have to state how many elements there are inside of them. (How big it is)
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result; //NOTE THE NO CURLY BRACES.
        }



        public static bool CheckForBlackJack(List<Card> Hand)
        {
            return;
        }

    }
}
//This class is to give perameters. 
//Jesse has done this before. Don't let that intimidate you. He has already put the thought into it. 

//Private is used if something is only used within its own class. Marking it private is a good habit. 
//Public might cause conflict with similar names. static is so we don't have to create another 21 object.  
//if a class or method is static, that means it's called by the type itself, and not by an instance of the type.
// Face is the key here. int is the value.
// A naming convention in private casses is to use an underscore ahead of it.