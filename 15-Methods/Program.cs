// TIO: Reversing an Array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountToTen();

            //Instructor Solution. Generated consecutive list of numbers first
            //int[] arrayOfNums = GenerateNumbers(15);
            //PrintNumbers(arrayOfNums);
            //ReverseNumbers(arrayOfNums);

            // I think mine looks cleaner
            //ReverseArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });

            //int fibOutput = Fibonacci(8);
            //Console.WriteLine($"fibOutput: {fibOutput}");

            PrintFibSequence(20);


            Console.ReadKey();  
        }

        static void CountToTen()
        {
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine($"num: {num}");
                num++;
            }
        }

        /// <summary>
        /// Takes in an array and reverses it.
        /// </summary>
        /// <param name="arr">Array to reverse.</param>
        /// <returns>An array of the original array passed that is reversed.</returns>
        static int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];
            int reversedArrayIterator = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                reversedArray[reversedArrayIterator] = arr[i];
                Console.WriteLine($"reversedArray[reversedArrayIterator]: {reversedArray[reversedArrayIterator]}");
                reversedArrayIterator++;

            }

            Console.WriteLine();

            Console.WriteLine($"reversedArray: {reversedArray}");
            return reversedArray;
        }


        //Generates a list of sequential numbers of any size starting with 1
        static int[] GenerateNumbers(int size)
        {
            int[] array = new int[size];

            for(int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }

            return array;
        }

        static void PrintNumbers(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[i]: {arr[i]}");
            }
            Console.WriteLine();
        }

        static void ReverseNumbers(int[] arr)
        {
            // Initialize 1st index and beginning and 2nd at the end
            int firstIndex = 0;
            int secondIndex = arr.Length - 1;

            while(firstIndex < secondIndex)
            {
                int temp = arr[firstIndex];
                arr[firstIndex] = arr[secondIndex];
                arr[secondIndex] = temp;

                firstIndex++;
                secondIndex--;
            }
        } 

        static int Factorial(int num)
        {
            // establish base case -> when get to that point, we're done!
            if(num == 1)
            {
                return 1;
            }
            return num * Factorial(num - 1);

        }

        // 1, 1, 2, 3, 4,6, 13, 21, 34, 55

        static int Fibonacci(int num)
        {
            //Base Case: stop when this happens
            if (num == 1 || num == 2)
            {
                return 1;
            }

            //Otherwise, print sequence
            return Fibonacci(num - 2) + Fibonacci(num - 1);
        }

        /// <summary>
        /// creates a fib sequence that is as long as the passed in size value
        /// </summary>
        /// <param name="size">How long you want the fib sequence array to be.</param>
        /// <returns>The fibSequence based on the requested size</returns>
        static int[] PrintFibSequence(int size)
        {
            int[] fibSequence = new int[size];

            for (int i = 0; i < size; i++)
            {
                fibSequence[i] = Fibonacci(i + 1);

                Console.Write($"{fibSequence[i]} ");
            }

            Console.WriteLine();

            Random random = new Random();
            //int aRandomNum = random.Next();
            //Console.WriteLine($"random: {random}");
            //Console.WriteLine($"aRandomNum: {aRandomNum}");

            int aRandomNum = random.Next(5) + 1;
            Console.WriteLine($"aRandomNum: {aRandomNum}");

            return fibSequence;
        }
    }
}
