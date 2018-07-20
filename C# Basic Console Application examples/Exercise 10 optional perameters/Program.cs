using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10_optional_perameters
{
    class Program
    {
        static void Main(string[] args)
        {


            opOriginals mathMachine = new opOriginals(); //INSTANTIATING CLASS

            //INTRO
            Console.WriteLine("Hello and welcome! Bored of doing my console apps yet? Well here's another one! This one is designed to have \na method that takes in 2 integers (the second one optional) and return an integer after competing simple addition. \nPress enter to start.");
            Console.ReadLine();
            //END INTRO

            //SLEEP LOOP
            bool sleep = false;
            while (sleep == false)
            { 
                //PROGRAM RUN
                Console.WriteLine("\nFirt pick a number to have 20 added to it");

                //TRY CATCH BLOCK
                try
                {

                    int intakeValve = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nNow select a second number to add to the equation OR press enter to use the default number. This one is optional.");
                    string intakeValve2 = Console.ReadLine();
                    int tester;

               



                    if (int.TryParse(intakeValve2, out tester))
                    {
                        tester = Convert.ToInt32(intakeValve2);
                        int gimme = mathMachine.flow(intakeValve, tester);
                        Console.WriteLine(intakeValve + " + 20 + " + tester + " = " + gimme);
                    }
                    else
                    {
                        int gimme = mathMachine.flow(intakeValve);
                        Console.WriteLine(intakeValve + " + 20 + " + "default(5) = " + gimme);

                    }

                }
                catch(Exception malo)
                {

                    Console.WriteLine("\nERROR. This program failed because " + malo.Message + "\nPlease try again.");
                    continue;
                }
                //END TRY CATCH




                //END PROGRAM RUN

                Console.WriteLine("\nPress enter to quit the program or type 'again' to repeat this method.");
                string leave = Console.ReadLine();
                if (leave == "again" || leave == "Again" || leave == "AGAIN")
                {
                    sleep = false;
                }
                else
                {
                    sleep = true;
                }

            }
            //END SLEEP LOOP

            //CONCLUSION
            Console.WriteLine("Thank you for that enjoyable experience. Press enter to close the window.");
            Console.ReadLine();
            //END CONCLUSION


        }
    }
}
