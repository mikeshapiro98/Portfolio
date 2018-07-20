using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to have it multiplied by 50:");
            string userInput1 = Console.ReadLine();
            double userInput2 = Convert.ToDouble(userInput1);
            Console.WriteLine("Your number multiplied by 50 is: " + (userInput2 * 50));
            // Console.ReadLine();

           // System.Threading.Thread.Sleep(1500);
            Console.WriteLine("  ");

            Console.WriteLine("Enter a number to have 25 added to it: ");
            string userInput3 = Console.ReadLine();
            double userInput4 = Convert.ToDouble(userInput3);
            Console.WriteLine("Your number plus 25 is: " + (userInput4 + 25));
            // Console.ReadLine();


           // System.Threading.Thread.Sleep(1500);
            Console.WriteLine("  ");

            Console.WriteLine("Enter a number to have it divided by 12.5: ");
            string userInput5 = Console.ReadLine();
            double userInput6 = Convert.ToDouble(userInput5);
            Console.WriteLine("Your number divided by 12.5 is: " + (userInput6 / 12.5));
            //Console.ReadLine();


           // System.Threading.Thread.Sleep(1500);
            Console.WriteLine("  ");

            Console.WriteLine("Enter a number to find out if it's larger than 50: ");
            string userInput7 = Console.ReadLine();
            double userInput8 = Convert.ToDouble(userInput7);
            bool check = userInput8 > 50;
            Console.WriteLine("Result: " + check);
            //Console.ReadLine();

           // System.Threading.Thread.Sleep(1500);
            Console.WriteLine("  ");

            Console.WriteLine("Enter a number to find out its remainder after it's been divided by 7: ");
            string userInput9 = Console.ReadLine();
            double userInput10 = Convert.ToDouble(userInput9);
            Console.WriteLine("The remainder of your number after it's been divided by 7 is: " + (userInput10 % 7));
            //Console.ReadLine();

            //System.Threading.Thread.Sleep(1000);
            Console.WriteLine("  ");


            Console.WriteLine("Now lets check some conditions...");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            //Console.WriteLine("  ");
            Console.WriteLine("First let's check if 3 is greater than 2 AND 5 is greater than 4. Press enter to assess.");
            Console.ReadLine();
            //System.Threading.Thread.Sleep(500);

            bool isTrue = 3 > 2 && 5 > 4;

            if (isTrue == true)
            {
                Console.WriteLine("After the evaluation, the calculations show that the statement is: " + isTrue);
            }
            else
            {
                Console.WriteLine("The statement is false.");
            }

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Now let's check if 3 is greater than 2 OR 5 is greater than 4. Press enter to assess.");
            Console.ReadLine();
            //System.Threading.Thread.Sleep(500);

            bool isTrue2 = 3 > 2 || 5 > 4;

            if (isTrue2 == true)
            {
                Console.WriteLine("After the evaluation, the calculations show that the statement is: " + isTrue2);
            }
            else
            {
                Console.WriteLine("The statement is false.");
            }

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("  ");

            Console.WriteLine("Finally let's find out if 2 plus 2 IS NOT EQUAL to 4. Press enter to assess.");
            Console.ReadLine();
           // System.Threading.Thread.Sleep(500);

            bool isTrue3 = (2 + 2) != 4;

            if (isTrue3 == true)
            {
                Console.WriteLine("After the evaluation, the calculations show that the statement is: " + isTrue3);
            }
            else
            {
                Console.WriteLine("After the evaluation, the calculations show that the statement is: " + isTrue3);
            }

            Console.WriteLine("  ");
            Console.WriteLine("Thank you for completing this program. Please press enter to initiate self destruction of this window.");
            Console.ReadLine();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Self destructing in");
            Console.WriteLine("5");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("4");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1");
            System.Threading.Thread.Sleep(1000);


        }
    }
}
