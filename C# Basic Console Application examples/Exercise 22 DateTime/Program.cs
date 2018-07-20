using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_22_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome back to another exciting program! In this one we will be experimenting with date and time. \nPress enter to get started.");
            Console.ReadLine();
            Console.WriteLine("\nCurrently the date & time is "+ DateTime.Now +". You're alive to see it. Congratulations! Press enter.");
            Console.ReadLine();
            DateTime election = new DateTime(2020, 11, 03, 0, 0, 0);
            DateTime now = DateTime.Now;
            TimeSpan outOfOffice = election - now;
            Console.WriteLine("\nIt is exactly " + outOfOffice.Days + " days, " + outOfOffice.Hours + " hours, " +  + outOfOffice.Minutes  + " minutes, " + outOfOffice.Seconds + " seconds, & " + outOfOffice.Milliseconds + " milliseconds until we can vote a certain someone out\nof office.\nPress enter.");
            Console.ReadLine();
            bool failure = true;
            while(failure == true)
            {
                Console.WriteLine("Now enter a numer to see exactly what time it will be in that amount of hours.");
                int num1;
                bool res = int.TryParse(Console.ReadLine(), out num1);
                
                if (res)
                {

                    
                    Console.WriteLine("In " + num1 +" hours it will be " + DateTime.Now.AddHours(num1));
                    failure = false;
                }
                else
                {
                    Console.WriteLine("There was an error. Please try again.");
                }

            }

            Console.WriteLine("Thank you for completing this program. Press enter to close the window.");
            Console.ReadLine();

        }
    }
}


//1. Prints the current date and time to the console.

//2. Asks the user for a number.

//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.