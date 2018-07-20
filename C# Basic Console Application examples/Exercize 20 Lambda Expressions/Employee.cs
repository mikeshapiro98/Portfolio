using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_20_Lambda_Expressions
{
    class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int callerID { get; set; }




        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + callerID);

        }



    }
}
