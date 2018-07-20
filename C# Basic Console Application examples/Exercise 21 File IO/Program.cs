using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This porgram is designed to exemplify the use of File I/O");
            Console.WriteLine("Please enter a number to have it logged and then printed back to you");

            //SLEEP LOOP
            bool sleep = false;
            while (sleep == false)
            {
                //TRY CATCH BLOCK
                try
                {
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    string userNumToString = userNum.ToString();
                    File.WriteAllText(@"C:\Users\micha\OneDrive\Desktop\Logs\log.txt", userNumToString);

                    string reader = File.ReadAllText(@"C:\Users\micha\OneDrive\Desktop\Logs\log.txt");
                    Console.WriteLine("\nThe number contained in the file that was just logged is " + reader + ". Press enter to quit");
                    sleep = true;
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please only enter only a whole number. Please try again by entering a new number now.");
                    
                }
                //END TRY CATCH BLOCK

            }
            //END SLEEP LOOP
        }
    }
}

//1. Ask a user for a number.

//2. Log that number to a text file.

//3. Print the text file back to the user.