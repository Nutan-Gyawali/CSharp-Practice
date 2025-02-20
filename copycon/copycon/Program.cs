
using System;
using copycon;
internal class Program
{

    static Program()
    {
        Console.WriteLine("done");
    }
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //copy cd1 = new copy(10);
        //cd1.Display();

        //copy cd2 = new copy(cd1);
        //cd2.Display();

        //First f1 = new First();
        //Console.WriteLine(f1.x);

        //First f2 = new First();
        //Console.WriteLine(f2.x);

        //Second s1 = new Second(2);
        //Console.WriteLine(s1.x);

        //Second s2 = new Second(3);
        //Console.WriteLine(s2.x);

        Hello h1 = new Hello();// instance of a class
        Hello h2;// variable of a class
        h2 = new Hello();

        Hello h3 = new Hello();
        Hello h4 = h3;

        h3.x = 2000;
        Console.WriteLine(h1.x);
        Console.WriteLine(h3.x);
        Console.WriteLine(h4.x);
    }
}

class First
{
    public int x = 100;
}

class Second
{
    public int x;

    public Second(int x)
    {
        this.x = x;
    }
}

class Hello()
{
    public int x = 10;
}