//Application program which demonstrates all methods from Object Class


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Marvellous
{
    class Base
    {
    }
    class Derived : Base
    {
    }
    class Program
    {
        static void Main(string[] args)
        {

            // Use of GetType method
            Object ob1 = new Object();
            System.String s1 = "Marvellous aaaaa";
            Derived dobj = new Derived();
            Type type1 = ob1.GetType();
            Type type2 = s1.GetType();
            Type type3 = dobj.GetType();
            Console.WriteLine("Demonstration of GetType method");
            // Object class output
            Console.WriteLine("Information of object class");
            Console.WriteLine(type1.BaseType);
            Console.WriteLine(type1.Name);
            Console.WriteLine(type1.FullName);
            Console.WriteLine(type1.Namespace);
            // string output
            Console.WriteLine("Information of string class");
            Console.WriteLine(type2.BaseType);
            Console.WriteLine(type2.Name);
            Console.WriteLine(type2.FullName);
            Console.WriteLine(type2.Namespace);
            // Derived output
            Console.WriteLine("Information of Derived class");
            Console.WriteLine(type3.BaseType);
            Console.WriteLine(type3.Name);
            Console.WriteLine(type3.FullName);
            Console.WriteLine(type3.Namespace);
            // Demonstration of equals and ReferenceEquals
            Base obj1 = new Base();
            Base obj2 = new Derived();
            Base obj3 = new Base();
            string str1 = "String";
            string str2 = "String";
            string str3 = "String New";
            Console.WriteLine("Caparison of two object");
            Console.WriteLine(Object.Equals(obj1, obj2));
            Console.WriteLine(Object.Equals(str1, str2));
            Console.WriteLine(Object.ReferenceEquals(obj1, obj2));
            Console.WriteLine(Object.ReferenceEquals(obj2, obj2));
            Console.WriteLine(Object.ReferenceEquals(obj1, obj3));
            Console.WriteLine(Object.ReferenceEquals(str1, str2));
            Console.WriteLine(Object.ReferenceEquals(str1, str3));

            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(str3.GetHashCode());
            Console.WriteLine("Demonstration of toString method");
            int salary = 12000000;
            float percentage = 89.50f;
            string str4 = salary.ToString();
            string str5 = percentage.ToString();
            Console.WriteLine(str4);
            Console.WriteLine(str5);
        }
    }
}