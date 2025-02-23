using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class gen
    {
        
            public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;

            return false;

        }

        public void Add <T>(T a, T b)
        {
            dynamic aa = a;
            dynamic bb = b;
            Console.WriteLine(aa + bb);
        }
    }
    
}

//List<int> nu = new List<int>();
//nu.Add(10);
//nu.Add(20);
//nu.Add(30);
//nu.Add(40);
//nu.Add(50);
//nu.Add(60);

//for (int i = 0; i < nu.Count; i++)
//{
//    Console.WriteLine(nu[i]);
//}

//nu.Insert(5, 70);

//for (int i = 0; i < nu.Count; i++)
//{
//    Console.WriteLine(nu[i]);
//}


//generic collections are type safe as well as aauto risizing

// List <int> li = new List <int> ();

//public int CustId { get; set; }
//public string Name { get; set; } 
//public string Balace { get; set; }

 //public void Genericc()
        //{
        //    List<int> nu = new List<int>();
        //    nu.Add(10);
        //}