using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_MakingCalculator
{
    class Program
    {
        public double calculateTwoNumbers(double n1, double n2, char operatorInput)
        {
            double result;

            switch (operatorInput)
            {
                case '+':
                    result = n1 + n2;
                    break;
                case '-':
                    result = n1 - n2;
                    break;
                case '*':
                    result = n1 * n2;
                    break;
                case '/':
                    result = n1 / n2;
                    break;
                case '%':
                    result = n1 % n2;
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.WriteLine($"result {result}");
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my simple calculator!");
            Console.WriteLine("Enter number1");
            string stringNumber1 = Console.ReadLine();
            double number1 = Convert.ToDouble(stringNumber1);
            Console.WriteLine($"number1: {number1}");

            Console.WriteLine("Enter number2");
            string stringNumber2 = Console.ReadLine();
            double number2 = Convert.ToDouble(stringNumber2);
            Console.WriteLine($"number2: {number2}");

            Console.WriteLine("Type in operator to be performed on the 2 numbers:");
            string stringOperator = Console.ReadLine();
            char operatorInput = Convert.ToChar(stringOperator);
            Console.WriteLine($"operatorInput: {operatorInput}");

            Program program = new Program();
            program.calculateTwoNumbers(number1, number2, operatorInput);

            Console.ReadKey();


        }
    }
}
