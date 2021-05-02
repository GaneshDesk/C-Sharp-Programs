/*
Binary File IO
The BinaryReader and BinaryWriter classes are used for reading from and writing to a
binary file.
The BinaryReader class is used to read binary data from a file. A BinaryReader object is
created by passing a FileStream object to its constructor.
The BinaryWriter class is used to write binary data to a stream. A BinaryWriter object is
created by passing a FileStream object to its constructor.
*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinaryReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 65;
            double d = 3.14157;
            bool b = true;
            string s = "Marvellous Infosystems";
            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("MarvellousBinary",
                FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("MarvellousBinary", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
               }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
        }
    }
}