using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_10_optional_perameters
{
    class opOriginals
    {

        public int flow(int x, int y = 5)
        {
            int outputValve = x + 20 + y;
            return outputValve;
        }

    }
}
