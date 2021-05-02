// Application which handles the exception using try catch block.
using System;
class Program
{
    static void Main(string[] args)
    {
        // Program which handles the exception with try catch blck
        try
        {
            int no3 = 10;
            int no4 = 0;
            int ans2 = no3 / no4;
            Console.WriteLine("Hello");
        }
        catch (Exception e)
        {
            Console.WriteLine("Inside catch block");
            Console.WriteLine(e);
        }
        Console.WriteLine("Code succesfully executes");
    }
}