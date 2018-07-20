using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16_Overload_opperators
{
    public class Program 
    {
        static void Main(string[] args)
        {

            //Employee employee = new Employee();
            //List<Employee> employeeList = new List<Employee>();

            List<Employee> employeeList = new List<Employee>()
            {
                new Employee{ FirstName = "Jill", LastName = "Valentine", callerID = 1111},
                new Employee { FirstName = "Harry", LastName = "Mason", callerID = 2222 },
                new Employee {  FirstName = "James", LastName = "Sunderland", callerID = 3333 },
                new Employee {  FirstName = "Henry", LastName = "Townshend", callerID = 1111 },
          
            };

            List<Employee> employeeList2 = new List<Employee>()
            {
                new Employee{ FirstName = "Jill", LastName = "Valentine", callerID = 1111},
                new Employee { FirstName = "Harry", LastName = "Mason", callerID = 2222 },
                new Employee {  FirstName = "James", LastName = "Sunderland", callerID = 3333 },
                new Employee {  FirstName = "Henry", LastName = "Townshend", callerID = 1111 },

            };

            Console.WriteLine("List of employees:");

            foreach (Employee worker in employeeList)
            {
                worker.SayName();
                //Console.WriteLine(employee);

            }

            Console.WriteLine("\nUsing 2 lists and 2 foreach loops the employees will now be compared using the overloaded operator '==' to determine \nif any caller IDs are matching");


            foreach (Employee e1 in employeeList)
            {
                foreach (Employee e2 in employeeList2)
                {
                    bool compare = e1 == e2;
                    if (e1.FirstName == e2.FirstName)
                    {
                        continue;
                    }
                    else if (compare)
                    {
                        Console.WriteLine(e1.FirstName + " And " + e2.FirstName + " have the same caller ID.");
                    }
                    else
                    {
                        continue;
                        //Console.WriteLine(e1.FirstName + " And " + e2.FirstName + " are NOT the same.");
                    }




                }



            }




            Console.WriteLine("\nPress enter to quit.");
            Console.ReadLine();


          







        }
    }
}
//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.


//FAILURES



//employeeList.ForEach(Console.WriteLine);

//employee.SayName();


//for (int i =0; i< employeeList.Count; i++)
//{
//    Console.WriteLine(employeeList[i]);
//}


////EMPLOYEE 1
////Employee employee = new Employee();
//employee.FirstName = "Jill";
//employee.LastName = "Valentine";
//employee.callerID = 1111;
//employeeList += employee;
////EmployeeList.Add(employee1);
//// employeeList.Add(employee);

//////EMPLOYEE 2
//Employee employee1 = new Employee();
//employee1.FirstName = "Harry";
//employee1.LastName = "Mason";
//employee1.callerID = 2222;
//employeeList += employee1;
////employeeList.Add(employee);

// //EMPLOYEE 3
// //Employee employee3 = new Employee();
// employee.FirstName = "James";
// employee.LastName = "Sunderland";
// employee.callerID = 3333;
// EmployeeList.Add(employee);

// //EMPLOYEE 4 (SAME ID AS 1)
// //Employee employee4 = new Employee();
// employee.FirstName = "Henry";
// employee.LastName = "Townshend";
// employee.callerID = 1111;
// EmployeeList.Add(employee);

//if (e1.FirstName == e2.FirstName)
//{
//    continue;
//}

//else if (e1 == e2)
//{
//    Console.WriteLine(e1.FirstName + " And " + e2.FirstName + " have the same caller ID.");
//}