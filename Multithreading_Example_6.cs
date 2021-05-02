/*Multithreaded application with Non Static Thread procedure. In this application
we change default priority of thread.
*/
using System;
using System.Threading;
public class ThreadSleep
{
    public void Display()
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(t.Name + " is running");
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
public class Marvellous
{
    public static void Main()
    {
        ThreadSleep tsobj2 = new ThreadSleep();
        Thread t9 = new Thread(new ThreadStart(tsobj2.Display));
        Thread t10 = new Thread(new ThreadStart(tsobj2.Display));
        t9.Name = "Marvellous Ninth";
        t10.Name = "Marvellous Tenth";
        t9.Priority = ThreadPriority.Lowest;
        t10.Priority = ThreadPriority.Highest;
        t9.Start();
        t10.Start();
    }
}