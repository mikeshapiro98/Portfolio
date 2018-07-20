using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_16_Overload_opperators
{
    public class Employee 
    {

      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int callerID { get; set; }

      


        public void SayName() 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " " + callerID);

        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            bool isIt = employee1.callerID == employee2.callerID;

            return isIt;

        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            bool isItNot = employee1.callerID != employee2.callerID;

            return isItNot;

        }



    }
}
//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

//FAILURES


//public static bool operator ==(Employee first, Employee second)
//{
//    bool isIt = first.callerID != second.callerID;

//    if (isIt == true)
//    {
//        return true;
//    }
//    return false;
//}

//public Employee AddEmp (Employee employee)
//{
//    employee.AddEmp(employee);
//    return employee;
//}



//public static List<Employee> operator +(List<Employee> employees, Employee employee)
//{

//    employees.Add(employee);
//    return employees;

//}
