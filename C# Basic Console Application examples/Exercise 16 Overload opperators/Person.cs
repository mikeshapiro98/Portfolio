using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16_Overload_opperators

{
    public class Person
    {



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int callerID { get; set; }

      

        public virtual void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + callerID);

        }




    }
}
//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.