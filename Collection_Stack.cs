// Application Program which demonstrate use of Stack methods and properties.
using System;
using System.Collections;
public class Marvellous
{
    public static void Main(string[] args)
    {
        Stack st = new Stack();
        st.Push('E');
        st.Push('N');
        st.Push('U');
        st.Push('P');

        Console.WriteLine("Elements from stack: ");
        foreach (char c in st)
        {
            Console.Write(c + " ");
        }
        st.Push('2');
        st.Push('1');
        Console.WriteLine("peek stack: {0}", st.Peek());
        Console.WriteLine("Pop element from stack : {0}", st.Pop());
        Console.WriteLine("Elements from stack:");
        foreach (char c in st)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("Removing values ");
        st.Pop();
        st.Pop();
        st.Pop();
        Console.WriteLine("Current stack: ");
    foreach (char c in st)
        {
            Console.Write(c + " ");
        }
    }
}