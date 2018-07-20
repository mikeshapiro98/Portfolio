using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAYS AND LISTS EXERCISE

            Console.WriteLine("In this exercise we'll be going over some arrays and lists. Press enter to start.");
            Console.ReadLine();

            //STRING ARRAY

            bool valid = false;
            while (valid == false)
            { 

            string[] stringArray = new string[] { "This is index 0", "This is index 1", "This is index 2", "This is index 3", "This is index 4", "This is index 5", "This is index 6" };

            Console.WriteLine("First please type in an index place between 0 and 6 to see what's in that index and press enter");
                string testIndex = Console.ReadLine();
                int userIndex;
                bool test = int.TryParse(testIndex, out userIndex);
                
                if(test == false)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                    //break;
                }
                else if (userIndex < 0 || userIndex > 6)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                }

                else
                {
                    Console.WriteLine("You entered index number " + userIndex +". The informaton in that index is: \n" + stringArray[userIndex] + "\nPress enter to continue");
                    Console.ReadLine();
                    valid = true; 
                }
            }
            //END STRING ARRAY

            //TRANSITION
            Console.WriteLine("That was fun. Now let's try out an integer array. Press enter to continue.");
            Console.ReadLine(); 
            //END TRANSITION
            
            //INT ARRAY 

            bool valid2 = false;
            while (valid2 == false)
            {
                int[] intArray = new int[] { 101, 104, 108, 112, 116, 120, 124 };
                Console.WriteLine("Again, type in an index place between 0 and 6 to see what's in that index and press enter");
                string testIndex2 = Console.ReadLine();
                int userIndex2;
                bool test2 = int.TryParse(testIndex2, out userIndex2);

                if (test2 == false)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                    //break;
                }
                else if (userIndex2 < 0 || userIndex2 > 6)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                }

                else
                {
                    Console.WriteLine("You entered index number " + userIndex2 + ". The informaton in that index is: \n" + intArray[userIndex2] + "\nPress enter to continue");
                    Console.ReadLine();
                    valid2 = true;
                }

            }



            //END INT ARRAY


            //TRANSITION
            Console.WriteLine("Those were Arrays. Now let's move on to a list. Press enter to continue.");
            Console.ReadLine();
            //END TRANSITION


            //LIST 

            bool valid3 = false;
            while (valid3 == false)
            {
                List<string> stringList = new List<string> {"I am index 0 in this list"};
                stringList.Add("I am index 1 in this list");
                stringList.Add("I am index 2 in this list");
                stringList.Add("I am index 3 in this list");
                stringList.Add("I am index 4 in this list");
                stringList.Add("I am index 5 in this list");
                stringList.Add("I am index 6 in this list");

                Console.WriteLine("One more time. Type in an index place between 0 and 6 to see what's in that index and press enter");
                string testIndex3 = Console.ReadLine();
                int userIndex3;
                bool test2 = int.TryParse(testIndex3, out userIndex3);

                if (test2 == false)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                    //break;
                }

                else if (userIndex3 < 0 || userIndex3 > 6)
                {
                    
                    Console.WriteLine("There was an error. Please enter only whole numbers between 0 and 6");
                }

                else
                {
                    Console.WriteLine("You entered index number " + userIndex3 + ". The informaton in that index is: \n" + stringList[userIndex3] + "\nPress enter to continue");
                    Console.ReadLine();
                    valid3 = true;
                }
            }

            //CONCLUSION
            Console.WriteLine("This concludes this program designed to exemplify arrays and list. Thank you for completing it. Press enter to \nclose this window.");
            Console.ReadLine(); 
            //END CONCLUSION

        }
    }
}
