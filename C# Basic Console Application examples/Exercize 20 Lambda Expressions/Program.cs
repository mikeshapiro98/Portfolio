using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercize_20_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();


            //EMPLOYEE LIST INSTANSIATION
            List<Employee> empList = new List<Employee>()
            {
                new Employee { FirstName = "Joe", LastName = "Lands", callerID = 1 },
                new Employee { FirstName = "Harry", LastName = "Mason", callerID = 2 },
                new Employee { FirstName = "James", LastName = "Sunderland", callerID = 3 },
                new Employee { FirstName = "Joe", LastName = "Waters", callerID = 4 },
                new Employee { FirstName = "Peach", LastName = "Toadstool", callerID = 5 },
                new Employee { FirstName = "Mary", LastName = "Yu", callerID = 6 },
                new Employee { FirstName = "Stormy", LastName = "Daniels", callerID = 7 },
                new Employee { FirstName = "Akira", LastName = "Yakomoto", callerID = 8 },
                new Employee { FirstName = "Poppy", LastName = "Barret", callerID = 9 },
                new Employee { FirstName = "Ness", LastName = "Eb", callerID = 10 }

            };

            //INTRODUCTION

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Hello. In this program we will create 3 list from a larger list. The first list will be built with a 'conventional' \nforeach loop, the second and third will be built with Lambda Expressions. Press enter to see the lists.");
            Console.ReadLine();


            //END INTRODUCTION

            //SHOW LIST

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            Console.WriteLine("This is the list that the other lists will be made from. Press enter to see the next list.");

            foreach (Employee worker in empList)
            {
                worker.SayName();
            }
            Console.ReadLine();
            //END SHOW LIST 


            //CONVENTIONAL LIST CREATION

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("This list should only contain employees with the first name Joe. Press enter to see the next list.");

            List<Employee> joesList = new List<Employee>();
            foreach (Employee freshMeat in empList)
            {
                if (freshMeat.FirstName == "Joe")
                {
                    joesList.Add(freshMeat);

                }

            }
            foreach (Employee freshMeat in joesList)
            {

                freshMeat.SayName();
            }

            Console.ReadLine();
            //END CONVENTIONAL LIST CREATION



            //LAMBDA LIST CREATION

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("This list should also only contain employees with the first name Joe. Press enter to see the next list.");

            List<Employee> joesExpression = empList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee freshMeat in joesExpression)
            {

                freshMeat.SayName();
            }

            Console.ReadLine();
            //END LAMBDA LIST CREATION


            //LAMDA NUMERAL LIST CREATION   

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("This list should only contain employees with an ID number higher than 5. Press enter.");


            List<Employee> classist = empList.Where(x => x.callerID > 5).ToList();


            foreach (Employee freshMeat in classist)
            {

                freshMeat.SayName();
            }
            Console.ReadLine();
            //END LAMBDA LIST CREATION



            //CONCLUSION

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("Thank you for completing this not so interesting program. See you next time!");
            Console.ReadLine();


            //END CONCLUSION



        }
    }
}




//1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name, as well as an Id.At least two employees should have the first name "Joe".

//2. Using a foreach loop, create a new list of all employees with the first name "Joe".

//3. Do the same thing again, but this time with a lambda expression.

//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

//****************************************FAILURES/JUNKYARD********************************************************
//empList.Where(x => x.FirstName == );
//empList.Employee.FirstName.Where(x => x.FirstName == "Joe"); 


// List<Employee> joesList = 

//Console.WriteLine("\n"+joesList);

//List<Employee> joesExpression = new List<Employee>();

//foreach (Employee worker in empList)
//{
//    worker.SayName();
//}