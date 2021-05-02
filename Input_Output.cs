// C# application which demonstrates the Input output mechanisms
// ReadLine is used to accept the input and WriteLine is used to display the output
using System;
class Program
{
    static void Main(string[] args)
    {
        // Create local variable to accept the input
        int num = 0;
        string str;
        Console.WriteLine("Enter number");
        // Accept the input and convert into integer
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entered number is {0}", num);
        Console.WriteLine("Enter string");
        // Accept the input
        str = Console.ReadLine();
        Console.WriteLine("Entered string is {0}", str);
    }
}
/*
There are different inbuilt functions which are used to convert data types explicitly as.
ToBoolean - Converts a type to a Boolean value, where possible.
ToByte - Converts a type to a byte.
ToChar - Converts a type to a single Unicode character, where possible.
ToDateTime - Converts a type (integer or string type) to date-time structures.
ToDecimal - Converts a floating point or integer type to a decimal type.
ToDouble
- Converts a type to a double type.
ToInt16 - Converts a type to a 16-bit integer.
ToInt32 - Converts a type to a 32-bit integer.
ToInt64 - Converts a type to a 64-bit integer.
ToSbyte - Converts a type to a signed byte type.
Piyush Khairnar - 7588945488
आम्ही Technical संस्कार करतो !!!
©Marvellous Infosystems
Page 1Marvellous Infosystems : Microsoft .Net Framework with C#.
ToSingle - Converts a type to a small floating point number.
ToString - Converts a type to a string.
ToUInt16 - Converts a type to an unsigned int type.
ToUInt32 - Converts a type to an unsigned long type.
ToUInt64 - Converts a type to an unsigned big integer.
*/