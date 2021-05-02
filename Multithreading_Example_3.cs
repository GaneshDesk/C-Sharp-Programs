// Multithreaded application with Non Static Thread procedure which performs different task.
// Multithreaded application with Static Thread procedure.

using System;
using System.Threading;
// Multithreaded application with Non Static Thread procedure which performs different task.
public class MultipleTask
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
    public void DisplayB()
    {
        Thread t = Thread.CurrentThread;
        for (int i = 10; i >= 0; i--)
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
        Console.WriteLine("Multiple threads as a non static method performing different task");
        MultipleTask Mobj = new MultipleTask();
        Thread t5 = new Thread(new ThreadStart(Mobj.DisplayF));
        Thread t6 = new Thread(new ThreadStart(Mobj.DisplayB));

        t5.Name = "Marvellous Fifth";
        t6.Name = "Marvellous Sixth";
    }
}