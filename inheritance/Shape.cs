using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public abstract class Shape
    {
        public double Width, Height, Radius;
        public const float Pi= 3.14f;

        public abstract double GetArea();

    }

    public class Rectangle: Shape
    {
        public Rectangle(double Width, double Height) { 
        this.Width = Width;
            this.Height = Height;
                }

        public override double GetArea() {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }


        public override double GetArea()
        {
            return Radius * Pi * Radius;
        }
    }
}


