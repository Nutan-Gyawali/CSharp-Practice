//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace inheritance
//{
//    internal class excep
//    {
        
//       using inheritance;
//using System.Reflection.Metadata.Ecma335;

//internal class Program
//    {
//        private static void Main(string[] args)
//        {



//            try
//            {
//                //statments which will cause run time error
//                //statemnt that does not require execution when the run time error occurs
//                Console.WriteLine("enter 1st number");
//                int x = int.Parse(Console.ReadLine());

//                Console.WriteLine("Enter second number");
//                int y = int.Parse(Console.ReadLine());

//                if (y == 1)
//                {
//                    Console.WriteLine(x);
//                    return;
//                }

//                int z = x / y;
//                Console.WriteLine(z);


//            }

//            catch (DivideByZeroException ex1)
//            {
//                //statment which should execute only when the error occurs
//                Console.WriteLine(ex1.Message);
//                Console.WriteLine("Try again");
//            }

//            catch (FormatException f1)
//            {
//                Console.WriteLine("Input num");
//            }

//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            finally
//            {
//                Console.WriteLine("finally");
//            }
//            Console.WriteLine("\n Now the end");
//        }


//    }












//}
//}
