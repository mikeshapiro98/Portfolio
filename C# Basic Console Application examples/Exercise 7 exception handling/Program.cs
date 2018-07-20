using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {



            //1.Create a list of integers. Ask the user for a number to divide each number in the
            //list by. Write a loop that takes each integer in the list, divides it by the number
            //the user entered, and displays the result to the screen.


            //2.Run that code, entering in non - zero numbers as the user.Look at the displayed results.


            //3.Run that code, entering in zero as the number to divide by.Note any error messages you get.


            //4.Run that code, entering in a string as the number to divide by.Note any error messages you get.


            //5.Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program
            //display a message to the display to let you know the program has emerged from the try/catch block and
            //continued on with program execution.In the catch block, display the error message to the screen. Then
            //try various combinations of user input: valid numbers, zero and a string.Ensure the proper error
            //messages display on the screen, and that the code after the try/catch block gets executed.


            //INTODUCTION
            Console.WriteLine("Hey there! In this program we will be going over an example of the try catch method. Press enter to run the program.");
            Console.ReadLine();

            //END INTRODUCTION




            List<int> dividableList = new List<int>() { 10, 15, 17, 34, 88, 234, 223434 };
            bool sleep = true;

            while (sleep == true)
            {

                Console.WriteLine("First enter a number to have a list of predetermined integers divided by that number.\nIf the entry is not compatable, you should receive an error.");
                

                //TRY CATCH BLOCK
                try
                {
                    int usersNum = Convert.ToInt32(Console.ReadLine());



                    if (usersNum != 0)
                    {
                        Console.WriteLine("You selected " + usersNum + ". The list numbers divided by " + usersNum + " are:");
                    }

                    
                    
                    for (int i = 0; i < dividableList.Count; i++)
                    {
                        
                       
                            
                            int divided = dividableList[i] / usersNum;
                            Console.WriteLine(divided);
                            sleep = false;
                        
                    }

                    Console.ReadLine();

                }

                catch (Exception stix)
                {

                    Console.WriteLine("\nERROR");
                    Console.WriteLine(stix.Message);
                    Console.WriteLine("\nYou will now be brought back to start after emerging from the try catch block");
                    Console.ReadLine();
                }

                //END TRY CATCH BLOCK

                Console.WriteLine("\nYou are now outside of the try catch block");
                Console.ReadLine();
            }

            Console.WriteLine("This concludes the program exemplifying a try catch block");
            Console.ReadLine();



 









        }
    }
}
