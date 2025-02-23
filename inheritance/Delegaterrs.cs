using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public delegate void AddDelegate(int a, int b);
    public delegate void SayDelegate();
    public class Delegates
    {
        public void AddNum(int a , int b )
        {
            Console.WriteLine(a + b);
        }

        public void SayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}
//Delegates d = new Delegates();
//AddDelegate ad = new AddDelegate(d.AddNum);
// ad(10, 30);
// SayDelegate sd = new SayDelegate(d.SayHello);
// sd();