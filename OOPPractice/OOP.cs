using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    interface diamond1 {
        void display();
    }

    interface diamond2
    {
        void display();
    }

    class diamondSolver: diamond1, diamond2{

        public void display() {
            Console.WriteLine("Murad");
        }
    }


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

    abstract class A

    {
        public virtual void display() {
        
        }

        public abstract void display1();
    }

    // derived class name 'derived'
    // 'baseClass' inherit here
    class B : A
    {

        // overriding
        public override void display()
        {
            Console.WriteLine("Derived class");
        }

        public override void display1()
        {
            Console.WriteLine("Derived class");
        }
    }

    class Anything
    {
        static void Main(string[] args)
        {
            //A b = new B();

            //b.display();
            //b.display1();

            diamondSolver d = new diamondSolver();

            d.display();
        }
    }
}
