using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_NestingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just some nested loops fun!

            //1)
            //for(int row = 0; row < 5; row++)
            //{
            //    for(int col = 0; col < 10; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    //Makes it wrap around to the beginning of the line
            //    Console.WriteLine();
            //}

            ////2)
            //for (int row = 0; row < 10; row++)
            //{
            //    for (int col = 0; col <= row; col++)
            //    {
            //        //Add one * to col every time row + by one
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}

            //3) TIO: Pg 76. Print a Pyramid
            //for (int row = 0; row < 5; row++)
            //{
            //    for(int space = 0; space < 10; space++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int col = 0; col <= row * 2; col++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}


            //for (int row = 0; row < 5; row++)
            //{
            //    // This loop prints out the spaces.
            //    // Check out this pattern:
            //    // ROW      #SPACES      #STARS
            //    // 0        4            1
            //    // 1        3            3
            //    // 2        2            5
            //    // 3        1            7
            //    // 4        0            9
            //    // n        5 - n - 1    n * 2 + 1

            //    // Prints out the correct number of spaces
            //    for (int space = 0; space < 5 - row - 1; space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Prints out the correct number of stars.
            //    for (int star = 0; star < row * 2 + 1; star++)
            //    {
            //        Console.Write("*");
            //    }

            //    // Print this out to move down a line.
            //    Console.WriteLine();
            //}

            //4) TIO: FizzBuzz
            //Print out all numbers from 1-100, but if number is a multiplier of 3, print word 'Fizz' instead. 
            //if number is a multiplier of 5, print out 'Buzz'
            //if number is a multiple of 3 and 5, print 'FizzBuzz'

            Console.WriteLine("hiii");
            for(int i = 0; i < 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz")
                } else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz")
                } else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
            
            // Wait for the user to respond before closing...
            Console.ReadKey();

        }
    }
}
