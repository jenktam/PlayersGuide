using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        /* 
            * ask player if wants to play a new game
        */

        static void Main(string[] args)
        {
            // add method to board later
            string key = "";
            while (key != "Q")
            {
                key = Console.ReadKey().Key.ToString();

                Console.WriteLine("key: " + key);

            }
            Console.WriteLine("exiting...");
            return;

            Board board = new Board();
            board.CreateBoard();
            board.SetTileValue(0, 0, "x");
            board.SetTileValue(2, 1, "o");
            board.SetTileValue(2, 2, "o");
            board.printBoard();


            Console.ReadKey();
        }
    }
}