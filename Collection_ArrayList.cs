using System;
using System.Collections;
public class Marvellous
{
    public static void Main(string[] args)
    {
        ArrayList al = new ArrayList();
        al.Add(11);
        al.Add(21);
        al.Add(51);
        Console.WriteLine("Capacity: {0} ", al.Capacity);
        Console.WriteLine("Count: {0}", al.Count);
        Console.Write("Content of arraylist: ");
        foreach (int i in al)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\nArrayList after Sorting:");
        al.Sort();

        foreach (int i in al)
        {
            Console.Write(i + " ");
        }
        al.Add(9.7);
        al.Add("Marvellous");
        al.Add('M');
        Console.WriteLine("\nContent of arraylist: ");
        foreach (Object i in al)
        {
            Console.Write(i + " ");
        }
        // Access element of arraylist using index
        int j = (int)al[0];
        Console.WriteLine("\nAccessed element is {0}", j);
        Console.WriteLine("Traversal using for loop");
        for (int k = 0; k < al.Count; k++)
        {
            Console.WriteLine(al[k]);
        }
        // Inserting element at specific position
        al.Insert(2, 101);
        // Remove the element by value
        al.Remove(101); //Removes 101 from ArrayList
                        // Remove the element by index
        al.RemoveAt(1); // Remove element at index 1
        Console.WriteLine("Traversal using for loop after update");
        for (int k = 0; k < al.Count; k++)
        {
            Console.WriteLine(al[k]);
        }
    }
}