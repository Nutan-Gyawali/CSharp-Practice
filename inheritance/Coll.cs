using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Coll
    {
        public void collection()
        {

            ArrayList al = new ArrayList(10);
            Console.WriteLine(al.Capacity);

            al.Add(100);
            Console.WriteLine(al.Capacity);

            al.Add(100); al.Add(100); al.Add(100); al.Add(100);
            al.Add(100);
            Console.WriteLine(al.Capacity);

            foreach (object obj in al)
            {
                Console.WriteLine(obj);
            }

            al.Insert(3, 350);
            Console.WriteLine("\n");
            foreach (object obj in al)
            {

                Console.WriteLine(obj);
            }

        }

    }
}

//Hashtable ht = new Hashtable();
//ht.Add("name", "Nutan");
//ht.Add("id", 123);
//ht.Add("email", "nutan@");

//Console.WriteLine("Hwlleep".GetHashCode());

//foreach (object key in ht.Keys)
//{
//    Console.WriteLine(key);
//}