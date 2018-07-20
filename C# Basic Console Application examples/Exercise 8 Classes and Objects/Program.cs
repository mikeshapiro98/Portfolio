using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise_8_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {

                //INTRO
            packet packet = new packet();
            bool sleep = false;
            Console.WriteLine("Hello! This porgram will ask you for a whole number. It will then perform 3 mathmatical methods on that number \nand return the answers to each one. Press enter to start");
            Console.ReadLine();
                //END INTRO    
            
            
            //WHILE REPEAL LOOP
            while (sleep == false)
            {

                Console.WriteLine("\nPlease enter a whole number or type exit to end the program.");

                string entered = Console.ReadLine();

                try
                {

                    if (entered == "exit")
                    {
                        sleep = true;
                    }

                    else
                    {
                        int enteredNum = Convert.ToInt32(entered);

                        //packet.adding(enteredNum); //THIS DOESN'T WORK. NEEDS TO BE ASSIGNED TO A VARIABLE!
                        int write = packet.adding(enteredNum);
                        Console.WriteLine("\n" + enteredNum + " + 5 is: " + write);

                        //packet.subtract(enteredNum);
                        int write2 = packet.subtract(enteredNum);
                        Console.WriteLine("\n" + enteredNum + " - 3 is: " + write2);

                        //packet.multiply(enteredNum);
                        int write3 = packet.multiply(enteredNum);
                        Console.WriteLine("\n" + enteredNum + " * 6 is: " + write3);



                    }

                }
                 catch (Exception /*stix*/)
                {

                    Console.WriteLine("\nERROR \nPlease enter only whole numbers or 'exit'");
                    //Console.WriteLine(stix.Message); //TO WRITE A DEFAULT MESSAGE
                    //Console.ReadLine();
                }



               



            }
            //END WHILE REPEAT LOOP

            Console.WriteLine("\nThank you for completing this program. Goodbye!");
            Console.ReadLine();

        }
    }
}
