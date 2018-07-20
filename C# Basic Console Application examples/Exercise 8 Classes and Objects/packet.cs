using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_Classes_and_Objects
{
    public class packet
    {


        public int adding(int adder)
        {
            int result = adder + 5;

            //Console.WriteLine("\n" + adder + " + 5 is: " + result); ??? THIS SHOULD BE MOVED TO THE PROGRAM FOR THIS ASSIGNMENT ???
            return result;
        }

        public int subtract(int subber)
        {
            int result = subber - 3;

           // Console.WriteLine("\n" + subber + " - 3 is: " + result);
            return result;
        }

        public int multiply(int multi)
        {
            int result = multi * 6;

           // Console.WriteLine("\n" + multi + " * 6 is: " + result);
            return result;
        }

        
    }
}
