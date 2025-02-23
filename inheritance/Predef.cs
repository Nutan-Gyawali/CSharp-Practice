using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate3(int  x, float y, double z);
    public delegate bool Delegate2(string str);
    internal class Predef
    {
        public static double AddNum(int x, float y, double z)
        {
            return x + y + z;

        }

        public static void AddNums1(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool Checklen(string str)
        {
            if (str.Length > 5)
                return true;

            return false;
        }
    }
}

//Func<int, float, double, double> obj1 = Predef.AddNum;
//double result = obj1.Invoke(100, 34.3f, 193.345);
//Console.WriteLine(result);

//Action<int, float, double> obj2 = Predef.AddNums1;
//obj2.Invoke(122, 3.4f,123.456);

//Predicate<string> obj3 = Predef.Checklen;
//bool status = obj3.Invoke("nutannn");
//Console.WriteLine(status);