using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4_string_fucntions
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRO!
            Console.WriteLine("Welcome. This program is to demonstrate string functions. Press enter to continue");
            Console.ReadLine();
            //END INTRO!

            //VAR ASSIGN
            string concat1 = "This is 3 strings ";
            string concat2 = "combined into a single ";
            string concat3 = "sentance using concatenation.";
            string upperLower = "This sentance will be changed to upper and lower case. ABC";
            //END VAR ASSIGN!

            //EXAMPLE 1 !
            Console.WriteLine(" ");
            Console.WriteLine("Here are three strings: ");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(concat1);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(concat2);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(concat3);
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine(" ");
            Console.WriteLine("Now here they are conatenated together:");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(" ");
            Console.WriteLine(concat1 + concat2 + concat3);
            //END EXAMPLE 1

            //TRANSITION!
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue to the next example");
            Console.ReadLine();
            //END TRANSITION!

            //EXAMPLE 2
            Console.WriteLine("This is an example of changing a string from lower to uppercase using the \".ToUpper\" \n and \".ToLower\" :");
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("First the initial string: ");
            Console.WriteLine(upperLower);
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Now let's capitalize that sting: ");
            upperLower = upperLower.ToUpper();
            Console.WriteLine(upperLower);
            Console.WriteLine(" ");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Now to lowercase: ");
            upperLower = upperLower.ToLower();
            Console.WriteLine(upperLower);
            //END EXAMPLE 2

            //TRANSITION
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue to the next example.");
            Console.ReadLine();
            //END TRANSITION

            //EXAMPLE 3

            Console.WriteLine(" ");
            Console.WriteLine("Now an example of a stringbuilder will be presented as a paragraph that is written and added sentance by sentance");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(" ");
            
            //Stringbuilder instantiation
            StringBuilder ex = new StringBuilder();
            ex.Append("\t This paragraph is exemplifying the use of a stingbuilder in C#. ");
            ex.Append("Regular string data types are immutable \n meaning that they can't be changed, only replaced. ");
            ex.Append("A stringbuilder allows for a string to be changed rather than \n just replaced eveytime with a new string. ");
            ex.Append("This can be very useful when text continuously needs to be added or updated \n to a single string. ");
            ex.Append("Constanly replacing large strings with new large strings can start taking up quite a bit of \n memory. ");
            ex.Append("The stringbuilder can save memory and allow you to add and modify a string as you see fit. ");
            Console.WriteLine(ex);
            //END STRINGBUILDER

            //JUST FOR FUN
            Console.WriteLine(" ");
            StringBuilder fun = new StringBuilder();
            fun.Append("This ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(400);
            fun.Append("is ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(400);
            fun.Append("fun ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(400);
            fun.Append("with ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(400);
            fun.Append("string ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(400);
            fun.Append("builder. ");
            Console.WriteLine(fun);
            System.Threading.Thread.Sleep(2000);
            //END JUST FOR FUN


            //END EXAMPLE 3!

            //CONCLUSION
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("  This concludes the sting funcions example program. Thank you for completing it. Press enter to close the window. ");
            Console.ReadLine();
            //END CONCLUSION!


        }
    }
}
