using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Employee<string> employeeString = new Employee<string>();
            employeeString.FirstName = "String";
            employeeString.LastName = "Generics";
            //employeeString.callerID = 1776;
            employeeString.things = new List<string>();
            employeeString.things.Add("Hello");
            employeeString.things.Add("this");
            employeeString.things.Add("is");
            employeeString.things.Add("a");
            employeeString.things.Add("string");
            employeeString.things.Add("list");


            Employee<int> employeeInt = new Employee<int>();
            employeeInt.FirstName = "Int";
            employeeInt.LastName = "Generics";
            //employeeInt.callerID = 1567;
            employeeInt.things = new List<int>();
            employeeInt.things.Add(1);
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(1);
            employeeInt.things.Add(1);
            employeeInt.things.Add(2);
            employeeInt.things.Add(3);
            employeeInt.things.Add(2);
            employeeInt.things.Add(1);

            employeeString.SayName();
            employeeString.copy();
            employeeInt.SayName();
            employeeInt.copy();




            Console.ReadLine();
        }
    }
}

//1. Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
