// Application Program which demonstrate use of HashTable methods and properties.
using System;
using System.Collections;
public class Marvellous
{
    public static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht.Add("10", "Pre-Placement Activity");
        ht.Add("11", "Angular");
        ht.Add("12", "Logic Building");
        ht.Add("13", "Inndustrial Project Development");
        ICollection keys = ht.Keys;
        Console.WriteLine("Elemnts of Hashtable after removal");
        foreach (String k in keys)
        {
            Console.WriteLine(ht[k]);
        }
        ht.Remove("11");
        Console.WriteLine("Elemnts of Hashtable after removal");
        foreach (String k in keys)
        {
            Console.WriteLine(ht[k]);
        }
    }
}