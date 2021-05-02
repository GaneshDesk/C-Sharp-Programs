/* C# application which demonstrates the use of out keyword while passing parameters to the function.

C# provides out keyword to pass arguments as out-type.
It is like reference-type, except that it does not require variable to initialise before
passing.
*/
using System;
namespace Out_Parameter
{
    class MarvellousDemo
    {
        public void fun(out int no)
        {
            no = 11;
        }
    }
    class Marvellous
    {
        static void Main(string[] args)
        {
            int value1, value2 = 10;
            MarvellousDemo dobj = new Demo();
            //Console.WriteLine("Before call {0}", value1);
            dobj.fun(out value1);
            Console.WriteLine("After call {0}", value1);

            Console.WriteLine("Before call {0}", value2);
            dobj.fun(out value2);
            Console.WriteLine("After call {0}", value2);
        }
    }
}