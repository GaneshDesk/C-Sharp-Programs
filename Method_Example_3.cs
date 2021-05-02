// C# application which demonstrates the way of passing array to the method.
// Passing array to the function
using System;
namespace Function_and_Array
{
    class MarvellousDemo
    {
        static void Display(int[] arr)
        {
            Console.WriteLine("Elements of array are :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20, 30, 40 };
            int[] arr2 = { 11, 21, 51 };
            Display(arr1);
            Display(arr2);
        }
    }
}