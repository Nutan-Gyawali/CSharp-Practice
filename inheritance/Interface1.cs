using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal interface Interface1
    {

        public int add(int a, int b);



    }

    class ImplementationClass : Interface1
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}
