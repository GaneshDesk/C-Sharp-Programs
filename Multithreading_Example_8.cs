// Multithreaded application which accept parameter from main thread using Lambda Expression.
using System;
using System.Threading;
public class SingleTask2
{
    public void DisplayF(int no)
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < no; i++)
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
        Console.WriteLine("Threads which accept parameter using Lambda Expression");
        SingleTask2 S1 = new SingleTask2();
        Thread t = new Thread(() => S1.DisplayF(11));
        t.Name = "Marvellous";
        t.Start();
    }
}