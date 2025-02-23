using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public delegate void AreaDelegate(int a, int b);
    class Multicastdel
    {
        public void getArea(int len, int wid)
        {
            Console.WriteLine(len * wid);
        }

        public void getPer(int a, int b)
        {
            Console.WriteLine(a + a + b + b);
        }
    }
}
//Multicastdel m = new Multicastdel();
// AreaDelegate a = m.getArea;
// a += m.getPer;

// a(10, 20);

// a.Invoke(20, 30);