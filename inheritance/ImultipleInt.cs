using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    

    interface Interface2
    {
        void Display();
        void Say();
    }

    interface Interface3
    {
        void Display();
        void Say();
    }

    internal class ImultipleInt : Interface2, Interface3
    {
        //static void main (string[] args)
        //{
        //    Console.WriteLine("hello");
        //}
        public void Display()
        {
            Console.WriteLine("hello world");
        }

        void Interface2.Say()
        {
            Console.WriteLine("nutan");
        }

        void Interface3.Say()
        {
            Console.WriteLine("gyawali");
        }

    }
}
