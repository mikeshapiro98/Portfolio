using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    interface IWalkAway
    {

        void WalkAway(Player player);



    }
}

//THE .NET FRAMEWORK ALLOWS FOR MUTIPLE INHERITANCES FROM INTERFACES BUT NOT CLASSES

//EVERYTHING IN AN INTERFACE IS PUBLIC 
//ANY CLASS THAT INHERITS THIS WILL NOW HAVE TO HAVE IWALKAWAY() IN IT. 
//INTERFACE NAMEING MUST START WITH A CAPITAL I