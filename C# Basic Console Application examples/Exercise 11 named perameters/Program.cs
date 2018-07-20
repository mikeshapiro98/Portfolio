using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_11_named_perameters
{
    class Program
    {
        static void Main(string[] args)
        {

            nameFactory nameFactory = new nameFactory(); //INSTANTIATING CLASS

            //INTRO
          
                Console.WriteLine("Welcome to yet another console application. This time a method will be called that inputs 2 integers and returns a \nvoid. The first integer will have a math equation performed on it, and the second will be displayed to the screen.\nPress enter to start");
                Console.ReadLine();

            //END INTRO

            //SLEEP LOOP

            bool sleep = false;
            while (sleep == false)
            {
                try
                {

                    Console.WriteLine("\nEnter your first number.");
                    int userNum1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Now the second one. ");
                    int userNum2 = Convert.ToInt32(Console.ReadLine());
                    nameFactory.mathName(numeral: userNum1, figure: userNum2);
                    
                    

                }

                catch (Exception stilt)
                {

                    Console.WriteLine("\nERROR! \nThe method failed because " + stilt.Message + "Please try again.");
                    continue;

                }

                Console.WriteLine("\nPress enter to exit the program or type 'again' to enter 2 more numbers.");
                string finish = Console.ReadLine();
                if (finish == "again" || finish == "Again" || finish == "AGAIN")
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
            Console.WriteLine("You completed this one too! Good job. Press enter to close the window.");
            Console.ReadLine();
            //END CONCLUSION


        }
    }
}



//1. Create a class. In that class, create a void method that takes two integers as parameters.Have the method do a
//  math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3. Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name.