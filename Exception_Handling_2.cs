// Application which handles the exception with try catch and finally block
using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            int no5 = 10;
            int no6 = 0;
            int ans3 = no5 / no6;
        }
        catch (Exception e)
        {
            Console.WriteLine("Inside catch block");
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Inside finally block");
        }
        Console.WriteLine("Code succesfully executes");
    }
}