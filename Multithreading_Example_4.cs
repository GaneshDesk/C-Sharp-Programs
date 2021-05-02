/*
Multithreaded application with Non Static Thread procedure. Main thread abort
the execution of child thread. (Abort() method)
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
        ThreadSleep tsobj = new ThreadSleep();
        Thread t7 = new Thread(new ThreadStart(tsobj.Display));
        t7.Name = "Seventh";
        t7.Start();
        try
        {
            t7.Abort();
        }
        catch (ThreadAbortException tae)
        {

            Console.WriteLine(tae.ToString());
        }
    }
}