/*
String Oriented File IO
In this type of file IO we have to read and write the data in terms of string.
*/
using System;
using System.IO;
class Marvellous
{
    static void Main(string[] args)
    {
        string[] Batches = new string[] {"PPA", "Logic Building", "Angular",
"C# .Net", "Industrial Project Development", "UNIX Internals", "Python with Automation"};
        using (StreamWriter sw = new StreamWriter("abc.txt"))
        {
            foreach (string s in Batches)
            {
                sw.WriteLine(s);
            }
        }
        string line = "";
        using (StreamReader sr = new StreamReader("abc.txt"))
        {
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}