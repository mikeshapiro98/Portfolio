using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_17_Generics
{
    class Employee<T>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int callerID { get; set; }
        public List<T> things { get; set; }

        public void SayName()
        {
            Console.WriteLine("\nName: " + FirstName + " " + LastName /*+ " " + callerID*/);

        }
        public void copy()
        {
            Console.WriteLine("\nList: ");
            for (int i = 0 ; i < things.Count; i++)
            Console.WriteLine(things[i]);

        }

    }

}
//1. Make the Employee class take a generic type parameter.

//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.