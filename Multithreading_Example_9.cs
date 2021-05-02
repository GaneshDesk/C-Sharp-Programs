// Multithreaded application which returns value from thread procedure using Lambda Expression.
using System;
using System.Threading;
public class SingleTask2
{
    public int DisplayF(int no)
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < no; i++)
        {
            Console.WriteLine(t.Name + " is running");
            Console.WriteLine(i);
        }
        return 1;
    }
}
public class Marvellous
{
    public static void Main()
    {
        Console.WriteLine("Thread which returns the value from thread procedure using Lambda Expression");
        SingleTask2 S1 = new SingleTask2();
        int value = 0;
        Thread t = new Thread(() => { value = S1.DisplayF(5); });
        t.Name = "Marvellous";
        t.Start();
        t.Join();
        Console.WriteLine("Return value from thread is {0}", value);
    }

}