// Multithreaded application with Static Thread procedure.

using System;
using System.Threading;


public class SingleTask1
{
    public static void DisplayF()
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(t.Name + " is running");
            Console.WriteLine(i);
        }
    }
}
public class Marvellous
{
    public static void Main()
    {
        Console.WriteLine("Multiple threads as a static method performing same task");
        Thread t1 = new Thread(new ThreadStart(SingleTask1.DisplayF));
        Thread t2 = new Thread(new ThreadStart(SingleTask1.DisplayF));
        t1.Name = "Marvellous First";
        t2.Name = "Marvellous Second";
        t1.Start();
        t2.Start();
    }
}