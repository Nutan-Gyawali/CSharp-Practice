using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    
   public abstract class Animal
    {
        public abstract void Says();
    }

    public class Dog : Animal
    {
        public override void Says()
        {
            Console.WriteLine("woof woof");
        }
    }

    public class Cat : Animal
    {
        public override void Says()
        {
            Console.WriteLine("Meow");
        }
    }
}
