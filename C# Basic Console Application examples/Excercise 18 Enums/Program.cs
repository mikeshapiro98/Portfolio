using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_18_Enums
{
    class Program
    {




        static void Main(string[] args)
        {
            //HOW TO CHANGE THE CONSOLE COLOR FOR REFERANCE 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;


            //SLEEP LOOP
            bool sleep = false;
            while (sleep == false)
            {

                Console.WriteLine("Please type what day of the week it is starting with a capital letter for a friendly message");

            
                //TRY CATCH BLOCK
                try
                {
                    string read = Console.ReadLine();

                    //GATE TO PREVENT NUMBERS FROM BEING SUCCESSFUL 
                    bool res = int.TryParse(read, out int num1);
                    if (res == false)
                    {
                        DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), read);
                        Console.WriteLine("It's " + day + "! That's the best day of the week because it ends in y.");
                        sleep = true;


                    }
                    else
                    {
                        Console.WriteLine("Please enter an actual day of the week.");
                    }

                   

                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter an actual day of the week.");

                }
                //END TRY CATCH
                

            }
            //END SLEEP LOOP
            Console.WriteLine("Thank you for completing this program. Press enter to close the window.");
            Console.ReadLine();
        }


        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }


    }
}


//1. Create an enum for the days of the week.

//2. Prompt the user to enter the current day of the week.

//3. Assign the value to a variable of that enum data type you just created.

//4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.

// *******************************************FAILURES/JUNK YARD****************************************************************************//


//Console.WriteLine(day);
//List<string> dayString = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Frday", "Saturday", "Sunday" };



//if (read == "Monday")
//{
//    Console.WriteLine(Enum.GetName(typeof(DaysOfTheWeek), 0));
//}




// Console.WriteLine(read);
//Console.WriteLine("The 4th value of the Colors Enum is {0}",
//Enum.GetName(DaysOfTheWeek);
//Enum.TryParse(read, out DaysOfTheWeek day);
//string comeAtMe = ((day).ToString());
//bool isItE = read == comeAtMe;
//if (isItE == true)
//{
//    Console.WriteLine(day);
//}


//if (read == "Monday" || read == "Tuesday" || read == "Wednesday" || read == "Thursday" || read == "Friday" || read == "Saturday" || read == "Sunday")
//{
//    // DaysOfTheWeek read = Console.ReadLine();
//    //Enum.TryParse(read, out DaysOfTheWeek day);
//    Console.WriteLine(day);
//    //Console.ReadLine();
//}


// DaysOfTheWeek day = Enum.TryParse(read);
// Enum.TryParse(read, out DaysOfTheWeek day);


// if(dayString.Contains(day))

//bool validator = false;
//if (dayString.Contains(read))
//{
//    validator = true;

//}
//if (validator == true)
//{
//    day = DaysOfTheWeek.Monday;
//}


//else
//{
//    validator = false;
//}



//bool gate;
//if (read == "Monday" || read == "Tuesday" || read == "Wednesday" || read == "Thursday" || read == "Friday" || read == "Saturday" || read == "Sunday")
//{
//    gate = true;
//}
//else
//{
//    gate = false;
//}

//Console.WriteLine(gate);




//    // foreach (DaysOfTheWeek days in Enum.GetValues(typeof(DaysOfTheWeek)))

//    // Console.WriteLine(days);


//    //    if (DaysOfTheWeek.Contains(read))
//    //{
//    //    day = DaysOfTheWeek.Monday;
//    //}


//try
//{





//    if (read == "Monday")
//    {
//        day = DaysOfTheWeek.Monday;
//    }
//    else if (read == "Tuesday")
//    {
//        day = DaysOfTheWeek.Tuesday;
//    }
//    else if (read == "Wednesday")
//    {
//        day = DaysOfTheWeek.Wednesday;
//    }
//    else if (read == "Thursday")
//    {
//        day = DaysOfTheWeek.Thursday;
//    }
//    else if (read == "Friday")
//    {
//        day = DaysOfTheWeek.Friday;
//    }
//    else if (read == "Saturday")
//    {
//        day = DaysOfTheWeek.Saturday;
//    }
//    else if (read == "Sunday")
//    {
//        day = DaysOfTheWeek.Sunday;
//    }
//    else
//    {
//        day = DaysOfTheWeek.Error;
//    }

//    //if (day != DaysOfTheWeek.Error)
//    //{
//    //    Console.WriteLine(day);
//    //}


//}
//catch
//{
//    //day = DaysOfTheWeek.Error;
//    Console.WriteLine("Please enter an actual day of the week.");

//}


// bool sleep = false;
//while (sleep == false)
//{


//}