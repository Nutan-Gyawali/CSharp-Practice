using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Customer
    {
        int _id;
        bool _status;
        string _name;

        public Customer(int cid, bool cstatus, string sname)
        {
            _id = cid;
            _status = cstatus;
           _name = sname;
        }


        public int cid
        {
            get { return _id; }
        }

        public bool cstatus
        {
            get { return _status; }
        }

        public string sname
        {
            get { return _name; }
           
            set {
                if (_status == false)
                    _name = value; 
            }
        }
    }

    
}
//Customer c = new Customer(101, false, "nutan");
//Console.WriteLine(c.cid);
//Console.WriteLine(c.cstatus);
//Console.WriteLine(c.sname);
//c.sname = "nutann";

//Customer c1 = new Customer(102, true, "bibek");
//Console.WriteLine(c1.cid);
//Console.WriteLine(c1.cstatus);
//Console.WriteLine(c1.sname);
//c1.sname = "bibelkk";

//Console.WriteLine(c1.sname);

//Console.WriteLine(c.sname);