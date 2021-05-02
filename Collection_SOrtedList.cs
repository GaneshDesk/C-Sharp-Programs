//Application Program which demonstrate use of SortedList methods and properties.
using System;
using System.Collections;
public class Marvellous
{
    public static void Main(string[] args)
    {
        SortedList sl = new SortedList();
        sl.Add("10", "Pre-Placement Activity");
        sl.Add("11", "Angular");
        sl.Add("12", "Logic Building");
        sl.Add("13", "Inndustrial Project Development");
        if (sl.ContainsValue("Linux System Programming"))
        {
            Console.WriteLine("This batch is already in the list");
        }
        else
        {
            sl.Add("15", "Linux System Programming");
        }
        ICollection keys = sl.Keys;
        foreach (String k in keys)
        {
            Console.WriteLine(sl[k]);
        }
        sl.Remove("11");
        Console.WriteLine("Elements of SortedList after removal");
        foreach (String k in keys)
        {
            Console.WriteLine(sl[k]);
        }
    }
}