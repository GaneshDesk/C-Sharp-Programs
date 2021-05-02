//Multithreaded application which accept parameter from main thread  using ParameterizedThreadStart.
using System;
using System.Threading;
public class SingleTask2
{
    public void DisplayF(Object no)
    {
        Thread t = Thread.CurrentThread;
        for (int i = 0; i < (int)no; i++)
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
        Console.WriteLine("Threads which accept parameter using ParameterizedThreadStart");
        SingleTask2 S1 = new SingleTask2();
        Thread t3 = new Thread(new ParameterizedThreadStart(S1.DisplayF));
        Thread t4 = new Thread(new ParameterizedThreadStart(S1.DisplayF));
        t3.Name = "Marvellous Third";
        t4.Name = "Marvellous Fourth";
        t3.Start(11);
        t4.Start(21);
    }
}