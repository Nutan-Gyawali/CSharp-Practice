using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    
    public abstract class  Class4
    {
        public abstract void Display();
        
    }

    internal class Abs: Class4
    {
        public override void Display()
        {
            Console.WriteLine("my name is mogambo");
        }
    }

}
