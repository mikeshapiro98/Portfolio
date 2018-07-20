using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9_methods_expansion
{
    class Program
    {
        static void Main(string[] args)
        {

            //DEFINE AND INSTANTIATE CLASS
            addomerators mathMachine = new addomerators();

            //INRO
            Console.WriteLine("Welcome! In this program we will be using methods to do math equations. Press enter to start.");
       

            //END INTRO

            bool sleep = false;
            string entered = Console.ReadLine(); //DEFINES THIS AS EMPTY TO START
            //WHILE REPEAT LOOP
            while (sleep == false)
            {


                //EXAMPLE 1
                bool loop1 = false;
                while (loop1 == false)
                {
                    Console.WriteLine("\nFor our first example please enter a whole number to perform a method that takes in an integer \nand returns an intger. Type 'exit' to quit the program.");
                    entered = Console.ReadLine();

                    if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                    {
                        
                        break; //THIS ONE BREAKS OUT OF LOOP 1
                        
                    }
                    else
                    {


                        try
                        {


                            int userInt = Convert.ToInt32(entered);
                            int write = mathMachine.original(userInt);
                            Console.WriteLine(userInt + " + (15 - 3) * 2 = " + write);
                            Console.WriteLine("\nPress enter to continue or type 'again' to enter another number to the operation.");
                            string answer = Console.ReadLine();

                            if (answer == "again" || answer == "Again") //COULD ALSO REVERSE THIS IF ELSE LOOP USING NOT EQUAL
                            {
                                loop1 = false;
                                //COULD ALSO USE BREAK
                            }

                            else
                            {

                                loop1 = true;
                                
                            }


                        }




                        catch (Exception stix)
                        {

                            Console.WriteLine("\nERROR \nThe program failed because " + stix.Message + " Please try again.");


                        }

                    }

                }
                //END EXAMPLE 1
                if (entered == "exit" || entered == "Exit" || entered == "EXIT") //THIS ONE BREAKS OUT OF SLEEP LOOP
                {
                    break;

                }




                //EXAMPLE 2
                bool loop2 = false;
                while (loop2 == false)
                {

                    Console.WriteLine("\nIn this next example you can enter any number including a decimal and the method will input a decimal and output \nan integer rounded up. Type 'exit' to quit the program.");
                    entered = Console.ReadLine();





                    try
                    {

                        if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                        {
                            break;
                        }
                        else
                        {

                            decimal userIntDec = Convert.ToDecimal(entered);
                            int write2 = mathMachine.original(userIntDec);
                            Console.WriteLine(userIntDec + " + 31.4 - 2.38 = " + write2 + " (rounded up)");
                            Console.WriteLine("\nPress enter to continue or type 'again' to enter another number to the operation.");
                            string answer = Console.ReadLine();

                            if (answer == "again" || answer == "Again")
                            {
                                loop2 = false;
                            }

                            else
                            {

                                loop2 = true;

                            }
                        }
                    }

                    catch (Exception stix)
                    {

                        Console.WriteLine("\nERROR \nThe program failed because " + stix.Message + " Please try again.");

                    }

                }
                //END EXAMPLE 2
                if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                {
                    break;

                }



                //EXAMPLE 3
                bool loop3 = false;
                while (loop3 == false)
                {

                    Console.WriteLine("\nFinally for this example please enter a whole which will be input into the method as a string and will be returned \nas an integer like magic! Type'exit' to quit the program.");
                    entered = Console.ReadLine();



                    try
                    {
                        if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                        {
                            break;
                        }
                        else
                        {

                            int finishHim = mathMachine.original(entered);
                            Console.WriteLine(entered + " - 15 + 45 * (18 / 3) = " + finishHim + " ");
                            Console.WriteLine("\nPress enter to continue or type 'again' to enter another number to the operation.");
                            string answer = Console.ReadLine();

                            if (answer == "again" || answer == "Again")
                            {
                                loop3 = false;
                            }

                            else
                            {

                                loop3 = true;

                            }

                        }
                    }

                    catch (Exception stix)
                    {

                        Console.WriteLine("\nERROR \nThe program failed because " + stix.Message + " Please try again.");

                        
                    }

                }
                //END EXAMPLE 3
                if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                {
                    break;

                }


                //OPTION TO RETURN TO START OR EXIT
                Console.WriteLine("Those were 3 examples of methods. Press enter to be brought back to the firse method again or type 'exit' to \nconclude the program.");
                entered = Console.ReadLine();

                if (entered == "exit" || entered == "Exit" || entered == "EXIT")
                {
                    sleep = true;
                    //COULD ALSO USE BREAK
                }
                else
                {

                    sleep = false;
                    //COULD ALSO USE CONTINUE

                }


                //END OPTION



            }
            //END WHILE REPEATE

            Console.WriteLine("\nThank you for completing this program. Press enter to close the window.");
            Console.ReadLine();


        }
    }
}


//1. Create a class. In that class, create a method that will take in an integer, do a math operation to it and then 
//   return the answer as an integer.

//2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. 3. Display the result to the screen.

//3. Add a second method to the class, with the same name, that will take in a decimal, do a different math
//   operation to it and then return the answer as an integer.

//4. In the Main() method of the console app, instantiate the class and call the second method, passing in a
//   decimal. Display the result to the screen.

//5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if 
//   possible, do a different math operation to it and then return the answer as an integer.

//6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string
//   that equates to an integer.Display the result to the screen.