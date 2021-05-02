// Application Program which demonstrate use of Queue methods and properties.
using System;
using System.Collections;
public class Marvellous
{
    public static void Main(string[] args)
    {
        Queue qobj = new Queue();
        qobj.Enqueue('A');
        qobj.Enqueue('B');
        qobj.Enqueue('C');
        qobj.Enqueue('D');
        Console.WriteLine("Current queue: ");
        foreach (char c in qobj)
        {
            Console.Write(c + " ");
        }
        qobj.Enqueue('F');
        qobj.Enqueue('G');
        Console.WriteLine("Current queue: ");
        foreach (char c in qobj)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("Removing some values ");
        char ch = (char)qobj.Dequeue();
        Console.WriteLine("The removed value: {0}", ch);
        ch = (char)qobj.Dequeue();
        Console.WriteLine("The removed value {0}",ch);
    }
}