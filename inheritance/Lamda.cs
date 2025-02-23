using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    //public delegate string GreetingsDelegate(string name);
    internal class Lamda
    {
        public static string Greet(string name)
        {
            return "hello " + name;
        }
    }
}

//GreetingsDelegate obj = name =>
//{
//    return "Hello " + name;
//};

//string str = obj.Invoke("rastra");
//Console.WriteLine(str);



//GreetingsDelegate obj = new GreetingsDelegate(Anynomous.Greetings);

//Console.WriteLine(obj.Invoke("Nutan"));

//GreetingsDelegate obj = delegate (string name)
//{
//    return "Hello" + name;
//};

//string str = obj.Invoke("Nutan");
//Console.WriteLine(str);


//GreetingsDelegate obj = new GreetingsDelegate(Lamda.Greet);
//string str = obj.Invoke("rasta");
//Console.WriteLine(str);
