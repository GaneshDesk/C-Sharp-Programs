/*Multithreaded application with Non Static Thread procedure. Main thread waits
till the execution of child thread gets completed. (Join() method)
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
        ThreadSleep tsobj1 = new ThreadSleep();
        Thread t8 = new Thread(new ThreadStart(tsobj1.Display));
        t8.Name = "Marvellous Eight";
        t8.Start();
        t8.Join();
        Console.WriteLine("Continue from main thread..");
    }
}