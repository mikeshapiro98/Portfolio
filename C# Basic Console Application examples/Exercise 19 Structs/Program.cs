using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19_Structs
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("This program simply prints a struct's value to the screen.  ");
            Number myLittleNumber = new Number();
            myLittleNumber.Amount = 1.37m;
            Console.WriteLine("\n$" + myLittleNumber.Amount + " is the average cost of a 4Ib. loaf of bread the year I was born. \nPress enter to close the window.");
            Console.ReadLine();



        }


    }
}


//1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

//2. In the Main() method, create an object of data type Number and assign an amount to it.

//3. Print this amount to the console.


