using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public long CountFactorial(long n)
        {
            long i, f = 1;
            for (i = 1; i <= n; i++)
            {
                f *= i;
            }

            return f;
        }

    }
}


    
