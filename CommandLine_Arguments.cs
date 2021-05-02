// C# application which demonstrates the concept of Command Line arguments.
using System;
class Marvellous
{
    static void Main(string[] args)
    {
        Console.WriteLine("Command line arguments are: ");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine("Argument number {0} is {1}",i , args[i]);
        }
    }
}