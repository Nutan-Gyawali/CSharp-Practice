using inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Throw
    {
    }

    public class DivideByOdd : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "odd number divo";
            }
        }
    }
}
//using inheritance;
//using System.Reflection.Metadata.Ecma335;

//internal class Program
//{
//    private static void Main(string[] args)
//    {

//        try
//        {
//            Console.WriteLine("enter 1");
//            int x = int.Parse(Console.ReadLine());

//            Console.WriteLine("emter 2");
//            int y = int.Parse(Console.ReadLine());

//            if (y % 2 > 0)
//            {
//                //throw new ApplicationException ("odd");

//                throw new DivideByOdd();
//            }

//            int z = x / y;
//            Console.WriteLine(z);

//        }

//        catch (Exception ex)
//        {
//            Console.WriteLine(ex);
//        }
//        finally
//        {

//        }


//    }


//}











