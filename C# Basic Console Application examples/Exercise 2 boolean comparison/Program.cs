using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2_boolean_comparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(50);
            int nums = rnd.Next();
            Console.WriteLine(nums);
            Console.ReadLine();

            ////INTRODUCTION TO PROGRAM!
            //Console.WriteLine("Hello there. Lets do some pet comparisons. Are you ready?");
            //string ready = Console.ReadLine();
            //if (ready == "no")
            //{
            //    Console.WriteLine("You're not ready? Close this window and come back when you are.");
            //}
            //else
            //{
            //    Console.WriteLine("Great! Let's get started.");
            //}

            //System.Threading.Thread.Sleep(1000);
            ////END INTRODUCTION!

            ////CONDITION STATEMENT NUMER 1(if)!
            //Console.WriteLine("Do you have any pets?");
            //string answer = Console.ReadLine();
            //bool affirm = answer == "yes";
            //bool negative = answer == "no";
            //if (affirm == true)
            //{
            //    Console.WriteLine("That's great. Pet's are perfect friends to have around, and provide many benefits to their human counterpart");
            //}
            //else if (negative == true)
            //{
            //    Console.WriteLine("Why not? Pets provide companionship and love to their human counterparts. Consider adopting a little furball today.");
            //}
            //else
            //{
            //    Console.WriteLine("There was an error. Please only answer yes or no.");
            //}
            //// END CONDITION STATEMENT NUMER 1!

            ////TRANSITION!
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Press enter to continue to the next comparison");
            //Console.ReadLine();
            ////END TRANSITION!


            ////CONDITION STATEMENT NUMBER 2(Longer Else if)!
            //int pets = 2;
            //Console.WriteLine("How many pets do you have?");

            //int petsOwned = Convert.ToInt32(Console.ReadLine());
            //bool none = petsOwned == 0;
            //if (petsOwned == pets)
            //{
            //    Console.WriteLine("That's the perfect amount of pets. Good job!");
            //}
            //else if (petsOwned > pets)
            //{
            //    Console.WriteLine("Wow that's a lot of pets. You must love animals");
            //}
            //else if (none == true)
            //{
            //    Console.WriteLine("Again, Why not?! Get to an adoption center NOW!");
            //}
            //else if (petsOwned < pets)
            //{
            //    Console.WriteLine("Just 1? Time to adopt one more!");
            //}
            //else
            //{
            //    Console.WriteLine("There was an error. Please only enter whole numbers");
            //}
            ////  END CONDITION STATMENT NUMBER 2!

            ////TRANSITION!
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine("Press enter to continue to the next comparison");
            //Console.ReadLine();
            ////END TRANSITION!


            ////CONDITION STATEMENT NUMBER 3(Ternary Statement)!
            //Console.WriteLine("Do you prefer cats or dogs?");
            //string selection = Console.ReadLine();
            //string catOrDog = selection == "cats" ? "Purrrfect! Cats are great pets. Did you know that a group of cats is called a clowder?" : "Man's best friend eh? Dogs are the best. Did you know that dogs can learn up to 1000 human words?";
            //Console.WriteLine(catOrDog);
            ////END CONDITION STATEMENT NUMBER 3!

            ////FINAL TRANSITION!
            //System.Threading.Thread.Sleep(1000);
            //Console.WriteLine(" ");
            //Console.WriteLine("Thank you for completing my pet comparisson program. I hope you enjoyed it. PLease press enter to close the window");
            //Console.ReadLine();
            ////END FINAL TRANSITION!

        }
    }
}
