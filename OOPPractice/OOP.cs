using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    interface TesterClass {
        int Name
        {
            get;
            set;
        }

    }

    interface TesterClass1
    {

    }

    class ChildClass: TesterClass, TesterClass1{
        int a;
        public ChildClass() : base() {
            a = 2;
        }

        public int Name
        {
            get { return this.a; }
            set { this.a = value; }
        }

    }

    class Anything
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }
}
