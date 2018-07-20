using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23_Extras
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRODUCTION
            Console.WriteLine("Hello again. In this program we will be going over some extra features on C# not previously covered. \nPress enter to get started.");
            Console.ReadLine();
            //END INTRO

            //CONSTANT VARIABLE
            const string conString = "You can't change me :P ";
            const int conInt = 28;
            Console.WriteLine("\"{0}\" and {1}", conString, conInt);
            Console.WriteLine("The above are examples of constant variables and therfore cannot be changed. Press enter to continue.");
            Console.ReadLine();
            //END CONSTANT VARIABLES.

            //"Var" keyword
            var stringVar = "I was created using the var keyword";
            var intVar = 101;
            Console.WriteLine("\"{0}\" and {1} are variables created using the \"var\" keyword", stringVar, intVar);
            Console.WriteLine("These ones are examples of variables defined by using only the var keyword. Press enter to continue.");
            Console.ReadLine();
            //END "Var" Keyword

            //CHAIN CONSTRUCTORS
            Console.WriteLine("The following superheros and their information was assembled using multiple chain constructors.");
     
            List<Superhero> heroes = new List<Superhero>
            {
               new Superhero ( "Superman", "Superhuman everything"),
               new Superhero ( "Batman has no jurisdiction...(Kind of Gotham City)"),
               new Superhero ( ),
               new Superhero ( "Wonder Woman", "Washington D.C.", "Superhuman Strength & Lasso Skills")
            };


            foreach (Superhero hero in heroes)
            {
                Console.WriteLine("\nName: " + hero.name + " \nCity of Jurisdiction: " + hero.city + " \nSuperpower: " + hero.superpower);

            }

            Console.WriteLine("Press enter to conclude.");
            Console.ReadLine();
            //END CHAIN CONSTRUCTORS

            //CONCLUSION
            Console.WriteLine("Hope you had fun. Goodbye for now!");
            Console.ReadLine();
            //END CONCLUSION





        }


    }
}
//1. Create a const variable

//2. Create a variable using the keyword "var".

//3. Chain two constructors together.



