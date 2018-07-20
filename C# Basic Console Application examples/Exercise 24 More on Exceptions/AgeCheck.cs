using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_24_More_on_Exceptions
{
    public class AgeCheck : Exception
    {
        public AgeCheck()
            : base()
                {
                    
                }
   


}
}
//1. Ask the user for his age.

//2. Display the year user born.

//3. Exceptions must be handled using "try .. catch".

//4. Display appropriate error messages if user enters zero or negative numbers.

//5. Display a general message if exception caused by anything else.