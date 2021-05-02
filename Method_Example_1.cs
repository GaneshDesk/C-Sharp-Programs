// C# application which demonstrates different ways of method calling techniques
/*
There are three ways in which we can call functions in C# as
1. Call by value
2. Call by address
3. Call by reference
*/
using System;
namespace Function_calling_Techniques
{
    class MarvellousDemo
    {
        public void FunValue(int no)
        {
            Console.WriteLine("Call by Value : {0}\n", no);
            no++;
        }
        public unsafe void FunAddress(int* ptr)
        {
            Console.WriteLine("Call by Address : {0}\n", *ptr);
            (*ptr)++;
        }
        public void FunReference(ref int no)
        {
            Console.WriteLine("Call by Reference : {0}\n", no);
            no++;
        }
    }
    class Marvellous
    {
        static unsafe void Main(string[] args)
        {
            int value1 = 10, value2 = 10, value3 = 10;
            MarvellousDemo dobj = new Demo();
            Console.WriteLine("Value before call {0}\n",value1);
            dobj.FunValue(value1);
            Console.WriteLine("Value after call {0}\n", value1);
            Console.WriteLine("Value before call {0}\n", value2);
            dobj.FunAddress(&value2);
            Console.WriteLine("Value after call {0}\n", value2);
            Console.WriteLine("Value before call {0}\n", value3);
            dobj.FunReference(ref value3);
            Console.WriteLine("Value after call {0}\n", value3);
        }
    }
}