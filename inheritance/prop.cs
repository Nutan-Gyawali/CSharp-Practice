using inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Circles
    {
        int Radius = 90;
        //public int getRad()
        //{
        //    return Radius; // provide only get access
        //}

        //public void setRadius(int r)
        //{
        //    Radius = r;
        //}

        //property
        public int RadiusProp
        {
            get { return Radius; }
            set { Radius = value; }
        }
    }
}


//Circles c = new Circles();
//int rad = c.RadiusProp;
//Console.WriteLine(rad);

//Circles c1 = new Circles();
//c1.RadiusProp = 20;
//Console.WriteLine(c1.RadiusProp);