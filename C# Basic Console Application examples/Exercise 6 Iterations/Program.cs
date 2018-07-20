using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {

            //INTRODUCTION
            Console.WriteLine("Hello. This is a program that meant to show the use of iteration in C#. Press Enter to start.");
            Console.ReadLine();
            //END INTRODUCTION

            //FIRST REQUIREMENT ADD USER STRINGS TOGETHER

            string[] stringAdds = { "This is an \t  | ", "array of stings   | ", "that will be \t  | ", "presented with the| ", "user input at \t  | ", "the end of \t  | ", "every three words | ", "Your input was: " };
            //string[] newUserString = new string[] { };
            Console.WriteLine("Add some text and press enter to have that text added to an array or strings and printed. Then press enter");
            string userString = Console.ReadLine();
            //List<string> newUserString = new List<string>(); FOR REFERANCE PURPOSES

            for (int i = 0; i < stringAdds.Length; i++)
            {
                Console.WriteLine(stringAdds[i]);
            }

            // foreach (var adders in stringAdds)
            for (int i = 0; i < stringAdds.Length; i++)
            {

                stringAdds[i] = (stringAdds[i] + userString);
                Console.WriteLine(stringAdds[i]);


                //newUserString[i] + userString;  //FOR REFERANCE PURPOSES
                //Console.WriteLine(stringAdds[i] + userString);
            }






            Console.ReadLine();

            //END FIRST REQUIREMENT

            //TRANSITION
            Console.WriteLine("That sure was fun. On to the next one! Press enter to continue.");
            Console.ReadLine();
            //END TRANSITION

            //SECOND REQUIREMENT    CREATE AN INFINITE LOOP

            /*

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("This loop is infinite!");
                i--;
            }

            */

            Console.WriteLine("This is an example of an infinite loop. This loop will not apear on the console in order to spare you the horrors \nof infinite time and space. Press continue to the next requirement.");
            Console.ReadLine();
            //END SECOND REQUIREMENT

            //TRANSITION
            Console.WriteLine("Now that there was an infinte loop created, let's close it up. Press enter to continue.");
            Console.ReadLine();
            //END TRANSITION

            //THIRD REQUIRMENT FIX LOOP 

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("This loop was infinite. Now it only holds a haiku.");
                Console.WriteLine("\tThe infinite loop\n\tIt can ruin your program\n\tIt's an easy fix ");
                Console.WriteLine("Press enter to continue. No really, press enter. That wan't part of the haiku . . . ");
                Console.ReadLine();

            }

            //END THIRD REQUIREMENT

            //UNNECISSARY 
            ////TRANSITION
            //Console.WriteLine("Okay let's move on. Press enter to continue.");
            //Console.ReadLine();
            ////END TRANSITION

            //FOURTH REQUIREMENT  USING THE < OPPERATOR ITERATION

            string counter = "tenletters";
            Console.WriteLine("This loop will iterate through a sting using the < opperator as an iterator.");

            for (int i = 0; i < counter.Length; i++)
            {
                Console.WriteLine(counter[i]);

            }

            Console.WriteLine("Yet again, press enter to continue.");
            Console.ReadLine();
            //END FOUTH REQUIREMENT 

            ////UNNECISSARY 
            ////TRANSITION
            //Console.WriteLine("Onward. You know what to do.");
            //Console.ReadLine();
            ////END TRANSITION

            //FIFTH REQUIREMENT USING THE <= OPPERATOR ITERATION

            Console.WriteLine("This will count the amount of iterations and print them to the screen using the <= operator as the iterator.");



            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

            }

            Console.WriteLine("As you can see, there are 11 index places as it starts at 0 and counts up to 10. To reduce the amount of enters pushed, we'll skip the tranisiton and go straigt to the next condition. But first...Press enter!");
            Console.ReadLine();
            //END FIFTH REQUIREMENT


            //SIXTH REQUIREMENT DISPLAY INDEX OF SEARCHED STRING

            List<string> searchables = new List<string>() { "banana", "apple", "pear", "grape", "strawberry", "orange", "raspberry", "mango", "blackberry", "blueberry" };
            bool validator = false;
            while (validator == false)
            {
                Console.WriteLine("In this loop example, you can search for one of the following terms to see what it's index number is inside of the list it lives in.");
                Console.WriteLine("Your options are:");
                Console.WriteLine("banana");
                Console.WriteLine("apple");
                Console.WriteLine("pear");
                Console.WriteLine("grape");
                Console.WriteLine("strawberry");
                Console.WriteLine("orange");
                Console.WriteLine("raspberry");
                Console.WriteLine("mango");
                Console.WriteLine("blackberry");
                Console.WriteLine("blueberry");
                Console.WriteLine("Please type in one of the options.");


                string searchee = Console.ReadLine();


                for (int f = 0; f < searchables.Count; f++)
                {

                    if (searchee == searchables[f])
                    {
                        Console.WriteLine("\nYou searched for " + searchables[f] + ". The index place of that item is " + f);
                        validator = true;
                        break;
                    }

                    else if (!searchables.Contains(searchee))
                    //else if (searchee != "banana" && searchee != "apple" && searchee != "pear" && searchee != "grape" && searchee != "strawberry" && searchee != "orange" && searchee != "raspberry" && searchee != "mango" && searchee != "blackberry" && searchee != "blueberry")
                    {
                        Console.WriteLine("\nThere was an error. Please only search from the given list and make sure it's spelled correctly. As punishment \npress enter");
                        Console.ReadLine();
                        break;
                    }



                }
            }

            //NOT RIGHT FOR THIS ONE
            //bool validator = true;
            //while (validator == true)
            //{
            //    switch(searchee)
            //    {
            //        case "banana":
            //            Console.WriteLine("Index number 0");
            //            validator = false;

            //            break;

            //        default:
            //            Console.WriteLine("default");
            //                break; 

            //    }


            //}

            Console.WriteLine("Excellent! now onto the next one. You know what to do. ");
            Console.ReadLine();
            //END SIXTH REQUIREMENT

            //SEVENTH/EIGHTH REQUIRMENT
            Console.WriteLine("It appears that the 7th and 8th requirements have already unknowingly been met! Yay! \nUnfornutately I'm going to make you press enter again.");
            Console.ReadLine();
            //END SEVENTH/EIGHTH REQUIREMENT

            //NINTH REQUIREMENT  DUPLICATED INDICIES

            List<string> veggies = new List<string>() { "carrot", "turnip", "pepper", "celery", "kale", "carrot", "turnip", "pepper", "celery", "kale" };
            // bool nest = true;
            bool sleep = true;
            while (sleep == true)
            {
                Console.WriteLine("Just like last time, this example will ask you to choose a term from a list, except this time each term is dulpicated\nwithin its list. Select one to see both of its indices");
                Console.WriteLine("Your options are:");
                Console.WriteLine("carrot");
                Console.WriteLine("turnip");
                Console.WriteLine("pepper");
                Console.WriteLine("celery");
                Console.WriteLine("kale");
                Console.WriteLine("Please type in one of the options.");
                string userVeg = Console.ReadLine();


                if (!veggies.Contains(userVeg))
                // if (userVeg != "carrot" && userVeg != "turnip" && userVeg != "pepper" && userVeg != "celery" && userVeg != "kale")
                {
                    Console.WriteLine("There was an error. Please only search from the given list and make sure it's spelled correctly. As punishment \npress enter");
                    Console.ReadLine();
                    //continue;
                }


                else
                {
                    Console.WriteLine("You selected " + userVeg + ". The indices of that veggie are: ");
                    for (int v = 0; v < veggies.Count; v++)
                    {


                        if (veggies[v] == userVeg)
                        {
                            Console.WriteLine(v);
                            sleep = false;

                        }


                    }
                }



                //for (int v = 5; v <= 9; v++)
                //{

                //    if (veggies[v] == userVeg)
                //    {
                //        Console.WriteLine("and");
                //        Console.WriteLine(v);
                //        sleep = false;
                //        break;

                //    }

                //}


            }
            Console.WriteLine("We're alost done. Just a few more times of pressing enter.");
            Console.ReadLine();

            //END NINTH REQUIREMENT

            //TENTH REQUIREMENT

            Console.WriteLine("Yet again this requirement has already been fulfilled. Kutos! PRESS ENTER.");
            Console.ReadLine();

            //END TENTH REQUIREMENT  FOR EACH STATMENT  

            // ELEVENTH REQUIREMENT  FIND DUPLICATES 
            List<string> finalList = new List<string>() { "spagettie", "matzo", "bread", "potatos", "spagettie", "rice", "cake", "bread", "dumplings", "polenta" };
            List<string> addList = new List<string>();

            // bool tester = false;

            Console.WriteLine("For our final iteration we will iterate through a loop and print each string in a list as well as print if the\nstring is a duplicate within the list. Press EnTeR to run the loop.");
            Console.ReadLine();

            foreach (var starch in finalList)
            {
                if (!addList.Contains(starch))
                {
                    addList.Add(starch);
                    Console.WriteLine(starch);
                }
                else
                {
                    Console.WriteLine("{0} has already been listed",
                        starch);
                }
            }

            //for (int s = 0; s < finalList.Count; s++)
            //// foreach (string starch in finalList)
            //{
            //    // Console.Write("\n"+starch);
            //    Console.Write("\n" + finalList[s]);
            //    for (int i = s + 1; i < finalList.Count; i++)
            //    //foreach(string starch in finalList)
            //    {

            //        if (finalList[i] == finalList[s])
            //        // if(finalList[s]==starch)
            //        {
            //            addList.Add(finalList[s]);

            //        }


            //    }

            //}

            Console.WriteLine("\nFingers tired yet? Press enter.");
            Console.ReadLine();
            //ELEVENTH REQUIRMENT 

            //CONCLUSION
            Console.WriteLine("This concludes this program exemplifying iterations. ONE LAST TIME... press enter.");
            Console.ReadLine();

            //END CONCLUSION

        }
    }
}
