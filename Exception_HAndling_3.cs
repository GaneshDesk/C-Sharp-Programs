// Application which generates the exception but there is no matching catch block
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int no7 = 10;
            int no8 = 0;
            int ans4 = no7 / no8;
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Inside catch block");
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Finally block is executed");
        }
        Console.WriteLine("Rest of the code");
    }
}