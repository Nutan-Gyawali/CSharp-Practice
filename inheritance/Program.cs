using inheritance;

internal class Program
{
    private static void Main(string[] args)
    {


        ImplementationClass a = new ImplementationClass();
        a.add(10, 20);
        Console.WriteLine(a.add(10, 20));


        //Rectangle r = new Rectangle(12.1, 12.2);
        //Circle c = new Circle(23.2);

        //Console.WriteLine(r.GetArea());
        //Console.WriteLine(c.GetArea());


        //Square square1 = new Square(10);
        //Square square2 = new Square(20);

        //int area = square1 * square1; ;
        //Console.WriteLine(area);

        //Rectangle r = new Rectangle(10, 7);
        //double a = r.area();
        //Console.WriteLine("Area: {0}", a);

        //Square s = new Square(20, 7);
        //double v = s.area();
        //Console.WriteLine("Area: {0}", v);


        //int x = 10;
        //int y = 20;
        //int z = x + y;
        //Console.WriteLine(z);
        //overridden o = new overridden();
        //o.nutan();

        //second s = new second();
        //s.nutan();

        //Gyawali g = new Gyawali();
        //g.Nutang2();

    }

       


}

//public class Person
//{
//   public int i;
//   public string Name, Address;
//}

//public class Student : Person
//{
//    int Class;
//    char Grade;
//    float Marks, Fees;
//}

//public class Staff : Person
//{
//    public double Salary;
//    public string Designation;
//}