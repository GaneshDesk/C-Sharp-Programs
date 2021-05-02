//Application which demonstrate use of Default, Parametrised and Copy constructors.
using System;
namespace Constructors_Destructors
{
    class Demo
    {
        public int i;
        public Demo()
        {
            this.i = 11;
            Console.WriteLine("Inside default constructor");
        }
        public Demo(int no)
        {
            this.i = no;
            Console.WriteLine("Inside parametrised constructor");
        }
        public Demo(Demo obj)
        {
            this.i = obj.i;
            Console.WriteLine("Inside copy constructor");
        }
        ~Demo()
        {
            Console.WriteLine("Inside Destructor");
          
}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo obj1 = new Demo();
            // Default constructor gets invoked
            Demo obj2 = new Demo(21);
            // Parametrised constructor gets invoked
            Demo obj3 = new Demo(obj2); // Copy constructor gets invoked
        }
    }
}