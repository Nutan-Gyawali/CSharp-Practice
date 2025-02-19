using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class overridden
    {

        public virtual void nutan()
        {
            Console.WriteLine("nutan");
        }
    }

    class second : overridden
    {
        public override void nutan()
        {
            Console.WriteLine("gyawali");
        }
    }
}
