using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24_More_on_Exceptions
{
    class Blanket
    {

        public void execute()
        {
            Console.WriteLine("\nPlease enter your age");
            bool tryit = int.TryParse(Console.ReadLine(), out int gimme);
            while (tryit)
            { 
                if (gimme > 0)
                {

                    DateTime currentYear = new DateTime();
                    currentYear = DateTime.Now.AddYears(-gimme);
                    int yearBorn = currentYear.Year;
                    Console.WriteLine("The year you were born is " + yearBorn + "!");
                    break;
                }
                else if (gimme <= 0)
                {
                    throw new AgeCheck();

                }
            }
            while(!tryit)
            {
                
                throw new Exception();
            }

        }


    }
}
