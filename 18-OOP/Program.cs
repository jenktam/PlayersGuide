//TIO: Pg 110: Die Rolling

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int dieRolls = requestNumberOfDieRolls();
            simulateDieRollsAndGetSum(dieRolls);

            Console.ReadKey();

        }

        static int requestNumberOfDieRolls()
        {
            Console.WriteLine("How many dice would you like to roll?");
            string stringNum = Console.ReadLine();
            int num = Convert.ToInt32(stringNum);
            Console.WriteLine($"num: {num}");

            return num;
        }

        static int simulateDieRollsAndGetSum(int num)
        {
            int[] randomRollsArray = new int[num];
            int result = 0;
            Random random = new Random();

            for(int i = 0; i < num; i++)
            {
                // chose 6 in next because rolling 6 sided die
                randomRollsArray[i] = random.Next(6) + 1; // number between 1 and 6. without +1, would just be 0-5
                result += randomRollsArray[i];

                if(i != num - 1)
                {
                    Console.Write($"{randomRollsArray[i]} + ");
                } else
                {
                    Console.Write($"{randomRollsArray[i]} = ");
                }
                //Console.WriteLine($"randomRollsArray[i]: {randomRollsArray[i]}");

            }
            Console.Write($"{result}");
            Console.WriteLine();

            Console.WriteLine($"result: {result}");
            return result;
        }
    }
}
