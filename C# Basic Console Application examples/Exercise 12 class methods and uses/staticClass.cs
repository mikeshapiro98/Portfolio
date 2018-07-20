using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12_class_methods_and_uses
{
    static class staticClass //MAKING A CLASS STATIC
    {

        public static int overloaded(int whole)
        {
            int result = whole - 15 * -8;
            return result;
        }

        public static double overloaded(double dec)
        {
            double result = dec / 2.7 + 34.567 - 21.75643;
            return result;
        }

        public static string overloaded(string str)
        {
            string result = str;
            return result;
        }

    }
}
