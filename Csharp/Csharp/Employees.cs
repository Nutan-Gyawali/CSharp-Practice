//using Csharp;
using System;
using System.Reflection.Metadata;

internal class Employees
{

    private int EmpId;
    private string EmpName;
    private int EmpAge;

    public Employees(int EmpId, string EmpName, int EmpAge) { 
         this.EmpId = EmpId;
        this.EmpName = EmpName;
        this.EmpAge = EmpAge;
    }

    public int getId()
    {
        return this.EmpId;
    }
    
    public String getName()
    {
        return this.EmpName;
    }

    public int getAge()
    {
        return this.EmpAge;
    }

    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Employees Ali = new Employees(1,"Nutan",34);
        Employees Nutan = new Employees(2, "Nutann", 20);

        Console.WriteLine(Ali.getId());
        Console.WriteLine("ali name is {0}",Ali.getName());

        Console.ReadLine();
        

       
    }
} 