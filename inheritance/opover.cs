using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class opover
    {

       

    }

    class Square
    {
        public int SideLength;
        public Square(int side)
        {
            SideLength = side;
        }
        public static int operator*(Square s1, Square s2)
        {
            return s1.SideLength * s2.SideLength;
        }

        
    }
}
