using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copycon
{
    internal class copy
    {
        int x;
         public copy(int i)
        {
            x = i;
        }
        public copy(copy obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine(x);
        }
    }
}
