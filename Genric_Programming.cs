/*
If we want to write application which is used to swap two elements then we
have to write separate method for each data type as
*/
// Specific Programming approach
using System;
public class Marvellous
{
    public void SwapInt(ref int no1, ref int no2)
    {
        int temp;
        temp = no1;
        no1 = no2;
        no2 = temp;
    }
    public void SwapFloat(ref float no1, ref float no2)
    {
        float temp;
        temp = no1;
        no1 = no2;
        no2 = temp;
    }
    public void SwapChar(ref char no1, ref char no2)
    {
        char temp;
        temp = no1;
        no1 = no2;
        no2 = temp;
    }
    public void SwapDouble(ref double no1, ref double no2)
    {
        double temp;
        temp = no1;
        no1 = no2;
        no2 = temp;
    }
}
public class Infosystems
{
    public static void Main(String[] arg)
    {
        int i1 = 11, i2 = 21;
        char ch1 = 'a', ch2 = 'b';
        float f1 = 3.14f, f2 = 6.14f;
        double d1 = 8.0, d2 = 9.0;
        Marvellous mobj = new Marvellous();
        Console.WriteLine("Before Swap integers {0} & {1}", i1, i2);
        mobj.SwapInt(ref i1, ref i2);
        Console.WriteLine("After Swap integers {0} & {1}", i1, i2);
        Console.WriteLine("Before Swap Characters {0} & {1}", ch1, ch2);
        mobj.SwapChar(ref ch1, ref ch2);
        Console.WriteLine("After Swap Characters {0} & {1}", ch1, ch2);
        Console.WriteLine("Before Swap Floats {0} & {1}", f1, f2);
        mobj.SwapFloat(ref f1, ref f2);
        Console.WriteLine("After Swap Floats {0} & {1}", f1, f2);
        Console.WriteLine("Before Swap doubles {0} & {1}", d1, d2);
        mobj.SwapDouble(ref d1, ref d2);
        Console.WriteLine("After Swap doubles {0} & {1}", d1, d2);
    }
}