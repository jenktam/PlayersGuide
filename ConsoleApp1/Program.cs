//Write a program that asks the user for 2 numbers and then using the rule prdoubles out whether the result is positive or negative if the 2 numbers were multiplied together?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number 1?");
            string stringNum1 = Console.ReadLine();
            double doubleNum1 = Convert.ToDouble(stringNum1);
            Console.WriteLine($"Number 1: {doubleNum1}");

            Console.WriteLine("Number 2?");
            string stringNum2 = Console.ReadLine();
            double doubleNum2 = Convert.ToDouble(stringNum2);
            Console.WriteLine($"Number 2: {doubleNum2}");
            bool isPositive;

            if(doubleNum1 == 0 || doubleNum2 == 0)
            {
                Console.WriteLine("Result won't be positive or negative bc it'll be 0!");
            }
            else if((doubleNum1 >= 0 && doubleNum2 >= 0) || (doubleNum1 < 0 && doubleNum2 < 0))
            {
                isPositive = true;
                Console.WriteLine($"isPositive {isPositive}");
            } else
            {
                isPositive = false;
                Console.WriteLine($"isPositive {isPositive}");
            }


            Console.ReadKey();
        }
    }
}
