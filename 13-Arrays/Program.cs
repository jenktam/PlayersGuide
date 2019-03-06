using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Min/Max Value in the Array
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMin = Int32.MaxValue;
            int currentMax = Int32.MinValue;
            Console.WriteLine($"currentMin0: {currentMin}");
            Console.WriteLine($"currentMax0: {currentMax}");

            foreach(int num in array)
            //for (int i = 0; i < array.Length; i++)
            {
                if (num < currentMin)
                {
                    currentMin = num;
                }

                if (num > currentMin)
                {
                    currentMax = num;
                }
            }

            Console.WriteLine($"currentMin: {currentMin}");
            Console.WriteLine($"currentMax: {currentMax}");

            //2. Avg Value in Array
            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int currentMin = Int32.MaxValue;
            //int total = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    total += array[i];
            //}

            //float avg = total / array.Length;

            //Console.WriteLine($"avg: {avg}");

            //3. TIO:Copying an Array
            //int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = new int[arr1.Length];
            //Console.WriteLine($"arr2.Length: {arr2.Length}");

            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    arr2[i] = arr1[i];
            //}

            ////Print out arr1
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"arr1[i]: {arr1[i]}");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write($"arr2[i]: {arr2[i]}");
            //}
            //Console.WriteLine();

            ////Print out arr2
            //Console.WriteLine($"arr1 {arr1}");
            //Console.WriteLine($"arr2 {arr2}");

            //4. Multi-dimensional Array
            //int[][] matrix = new int[4][];
            //matrix[0] = new int[2];
            //matrix[1] = new int[6];
            ////Continue filling in values for the jagged array...
            //Console.Write($"matrix[0]: {matrix[0]} ");
            //Console.Write($"matrix[1]: {matrix[1]} ");

            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (int column = 0; column < matrix[row].Length; column++)
            //    {
            //        Console.Write($"{matrix[row][column]} "); //Each item in the row separated by spaces
            //    }
            //    Console.WriteLine();
            //}


            //int[,] matrix = new int[4, 4];
            //for(int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for(int column = 0; column < matrix.GetLength(1); column++)
            //    {
            //        Console.Write($"{matrix[row, column]} ");
            //    }

            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
