using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_class_methods_and_uses
{
    class Program
    {
        static void Main(string[] args)
        {

           caller caller = new caller(); //INSTANTIATING CLASS

            //INTRO
            Console.WriteLine("Hey there! In this program there will be three examples desined to exemplify various things. Press enter to \nstart the program.");
            Console.ReadLine();

            //END INTRO


            //SLEEP LOOP
            bool sleep = false;
            while (sleep == false)
            {


                //RUN PROGRAM

                bool loop1 = false;
                while (loop1 == false)
                {

                    try
                    {
                        //FIRST EXAMPLE
                        Console.WriteLine("\nFirst enter a whole number to have it cut in half and rounded down after going through a void method.");
                        int useInt1 = Convert.ToInt32(Console.ReadLine());
                        caller.halver(useInt1);
                        Console.ReadLine();
                        loop1 = true;
                        //END FIRST EXAMPLE

                    }
                    catch (Exception style)
                    {
                        Console.WriteLine("ERROR \nThe program failed because " + style.Message + "Please try again.");
                    }
                }


                bool loop2 = false;
                while (loop2 == false)
                {

                    try
                    {
                        //SECOND EXAMPLE
                        Console.WriteLine("\nNow enter a whole number to have it go through a void method with output perameters");
                        int useInt2 = Convert.ToInt32(Console.ReadLine());
                        caller.putOut(useInt2, out int num);
                        Console.WriteLine(useInt2 + " * 2 / 3 = " + num);
                        Console.WriteLine("The output of the method performed on " + useInt2 + " is " + num);
                        Console.WriteLine("Press enter to continue. ");
                        Console.ReadLine();
                        loop2 = true;
                        //END SECOND EXAMPLE

                    }
                    catch (Exception style)
                    {

                        Console.WriteLine("ERROR \nThe program failed because " + style.Message + "Please try again.");

                    }

                }

                bool loop3 = false;
                while (loop3 == false)
                {

                    try
                    {
                        //THIRD EXAMPLE
                        Console.WriteLine("\nEnter a whole number OR a decimal to have an overloaded method in a static class perform various tasks to on the number");
                        string overAns = Console.ReadLine();
                        bool tryerOut = int.TryParse(overAns, out int spotPrawn);
                        int stat1 = spotPrawn;
                        //Console.WriteLine(spotPrawn);
                        double stat2 = Convert.ToDouble(overAns);

                        if (tryerOut == true)
                        {
                            int returnInt = staticClass.overloaded(stat1);
                            Console.WriteLine(stat1 + " - 15 * -8 = " + returnInt);
                            double returnDec = staticClass.overloaded(stat2);
                            Console.WriteLine(stat2 + " / 2.7 + 34.567 - 21.75643 = " + returnDec);
                            string retrunString = staticClass.overloaded(overAns);
                            Console.WriteLine("The number that you entered was " + retrunString + ". It has been put through 3 methods coming out as an integer, a double, and a string.");
                            loop3 = true;
                        }

                        else
                        {
                            Console.WriteLine("Your number was not an integer so the first method has been skipped");

                            double returnDec = staticClass.overloaded(stat2);
                            Console.WriteLine(stat2 + " / 2.7 + 34.567 - 21.75643 = " + returnDec);
                            string retrunString = staticClass.overloaded(overAns);
                            Console.WriteLine("The number that you entered was " + retrunString + ". It has been put through 2 methods coming out as a double and a string.");
                            loop3 = true;
                        }

                       
                        //END THIRD EXAMPLE
                    }
                    catch (Exception style)
                    {
                        Console.WriteLine("ERROR \nThe program failed because " + style.Message + "Please try again.");

                    }

                }

                //END RUN PROGRAM

                //EXIT OR RETURN
                Console.WriteLine("\nPress enter to finish the program or type 'again' to start the program over.");
                string exit = Console.ReadLine();
                if (exit == "again" || exit == "Again" || exit == "AGAIN")
                {
                    sleep = false;
                }
                else
                {
                    sleep = true;
                }



            }


            //CONCLUSION
            Console.WriteLine("\nHope you had fun! See you next time. Press enter to close the window");
            Console.ReadLine();

            //END CONCLUSION

        }
    }
}

//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.




//int numeral1;
//bool isItInt = int.TryParse(overAns, out numeral1);
// (isItInt == true)
//{

//    var letMe = numeral1;

//}


//int numeral1;
//bool isItInt = int.TryParse(overAns, out numeral1);



//double numeral2;
//bool isItDec = double.TryParse(overAns, out numeral2);

//bool test = true;
//while (test == true)
//{
//    if (isItInt == true)
//    {

//        int res = numeral1;
//        int tryer = res;

//    }
//    else if (isItDec == true)
//    {
//        double res = numeral2;

//    }
//    else
//    {
//        string res = overAns;

//    }



//}


//var overage = staticClass.overloaded(res);