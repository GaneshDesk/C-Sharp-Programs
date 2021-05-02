// Multithreaded application with Non Static Thread procedure.

using System;
using System.Threading;

public class SingleTask2
{
    public void DisplayF()
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

        Console.WriteLine("Multiple threads as a non static method performing same task");
        SingleTask2 S1 = new SingleTask2();
        Thread t3 = new Thread(new ThreadStart(S1.DisplayF));
        Thread t4 = new Thread(new ThreadStart(S1.DisplayF));
        t3.Name = "Marvellous Third";
        t4.Name = "Marvellous Fourth";
        t3.Start();
        t4.Start();
    }
}