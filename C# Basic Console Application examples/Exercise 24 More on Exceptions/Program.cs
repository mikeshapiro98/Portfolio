using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace Exercise_24_More_on_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO
            WriteLine("Hey there. Fancy meeting you here again. This is another program. Are you ready for it? Press enter.");
            ReadLine();
            //END INTRO

            //Start program
            Blanket blanket = new Blanket();

            //SLEEP LOOP
            bool sleep = false;
            while(sleep == false)
            {

                try
                {
                    
                    blanket.execute();
                    sleep = true;

                }
                catch (AgeCheck)
                {
                    WriteLine("\nYou've entered either a 0 or negative number. Please enter your correct age, or if you're zero and know how to use a \ncomputer, kudos, you were born this year. Please try again.");

                }
                catch (Exception)
                {
                    WriteLine("\nThere was a general error. Please try again.");
                }
               
            }
            //END SLEEP LOOP


            WriteLine("\nAnd so we conclude this program offering an example of exception handeling.");
            ReadLine();
            //End program




        }
    }
}
//1. Ask the user for his age.

//2. Display the year user born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if user enters zero or negative numbers.

//5. Display a general message if exception caused by anything else.


//DateTime currentYear = new DateTime(2018, 06, 08);

//else //if(!tryit)
//      {
//          throw new Exception();
//      }