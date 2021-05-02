/*
Byte Oriented File IO :
In this type of file IO we have to perform file operations in terms of bytes.
*/
using System;
using System.IO;
class Marvellous
{
    static void Main(string[] args)
    {
        FileStream F = new FileStream("Marvellous.dat", FileMode.OpenOrCreate,
        FileAccess.ReadWrite);
        for (int i = 1; i <= 50; i++)
        {
            F.WriteByte((byte)i);
        }
        F.Position = 0;
        Console.WriteLine("Contents from file are : ");
        for (int i = 0; i <= 50; i++)
        {
            Console.Write(F.ReadByte() + " ");
        }
        F.Close();
    }
}