using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class employee
    {
        int id;
        string name;
        string department;
        double Salary;

        public employee(int id, string name, string department, double Salary) { 
        this.id = id;
            this.name = name;
            this.department = department;
            this.Salary = Salary; 
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return id;

                else if (index == 1)
                    return name;

                else if (index == 2)
                    return department;

                else if (index == 3)
                    return Salary;
                return null;

            }

            set
            {
                if(index == 0)
                    id = (int)value;
                else if (index == 1)
                    name = (string)value;
                else if(index == 2)
                    department = (string)value;
                else if(index==3)
                    Salary = (double)value;


            }
        }

    }


}

//employee e = new employee(1, "Nutan", "IT", 101100.1);
//Console.WriteLine(e[0]);
//Console.WriteLine(e[1]);
//Console.WriteLine(e[2]);
//Console.WriteLine(e[3]);
//Console.WriteLine("\n");
//e[2] = "software";

//Console.WriteLine(e[0]);
//Console.WriteLine(e[1]);
//Console.WriteLine(e[2]);
//Console.WriteLine(e[3]);