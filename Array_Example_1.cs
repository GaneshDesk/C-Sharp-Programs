using System;
namespace MarvellousArray
{
    class Marvellous
    {
        static void Main(string[] args)
        {
            // Below syntax demonstrate creation of single dimensional array
            // First way
            int[] arr1 = new int[5];
            arr1[0] = 11;
            arr1[1] = 21;
            arr1[2] = 51;
            arr1[3] = 101;
            arr1[4] = 151;
            // Second way
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 };
            // Third way
            int[] arr3 = { 11, 22, 33, 44, 55 };
            // In this case arr3 and arr4 referring to same memory locations (Shallow copy)
            int[] arr4 = arr3;
            // Creating multi dimensional array (2D)
            // First way
            int[,] brr1 = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
            // Second way
            int[,] brr2 = new int[2, 2];
            brr2[0, 0] = 10;
            brr2[0, 1] = 20;
            brr2[1, 0] = 30;

            brr2[1, 0] = 30;
            // Third way
            int[,] brr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //Jagged array - Every row of different size
            int[][] crr = new int[2][];
            crr[0] = new int[3];
            crr[1] = new int[4];
        }
    }
}