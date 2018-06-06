using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //MADE ABSTRACT TO ENSURE THAT OTHERS CAN'T DO THIS IN OTHER CLASSES. PROTECTS YOUR PROGRAM.
    {

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        
        public Dictionary<Player, int> Bets { get; set; }  //REMEMBER A DICTIONARY TAKES A: key AND value. The key here is player the value is the amount. 

        public abstract void Play(); //ABSTRACT METHODS CAN ONLY WORK INSIDE OF AN ABSTRACT CLASS.. ALSO CONTAINS NOW IMPLIMENTATION. IT SAYS ANY CLASS INHERITING THIS CLASS MUST IMPLIMENT THIS METHOD. THINK OF IT AS A CONTRACT TO FOLLOW WHEN ANOTHER CLASS INHERITS IT. 

        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {

                Console.WriteLine(player.Name);

            }

        }


    }
}

//VIRTUAL METHOD NOTES
//Virtual method exists inside of the abstract class
//A virtual method is a method that gets inherited by an inheriting class but it has the ability to override it. 
//Virtual methods have implimentatons but they CAN be overridden
