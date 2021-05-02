// Application which demonstrate use of private and static constructor.
using System;
namespace Private_and_Static_constructor
{
    class Demo
    {
        public static int i = 10;
        private Demo()
        {
            Console.WriteLine("Inside private constructor");
        }
    }
    // We can not inherit class due to private constructor
    //class Derived : Demo { }
    class Hello
    {
        public static int i;
        static Hello()

        {
            i = 11;
            Console.WriteLine("Inside static constructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // We can not create object due to private constructor
            // Demo dobj = new Demo();
            Console.WriteLine("Value of static member {0}", Demo.i);
            Hello hobj1 = new Hello();
            Hello hobj2 = new Hello();
            Hello hobj3 = new Hello();
        }
    }
}