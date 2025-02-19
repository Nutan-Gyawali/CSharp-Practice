using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Hiding
    {
        public virtual void Nutang()
        {
            Console.WriteLine("h1");
        }

        public void Nutang2()
        {
            Console.WriteLine("h2");
        }
    }


    class Gyawali : Hiding
    {
        public new void Nutang2()
        {
            Console.WriteLine("h3");
        }
    }
}
