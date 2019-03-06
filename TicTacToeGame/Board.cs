using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Board
    {
        public Tile[,] board = new Tile[3, 3];

        public Tile[,] CreateBoard()
        {
            //Tile[,] matrix = new Tile[3, 3];

            int TileNumber = 1;

            //Iterates until row < length of 1st number in the matrix
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    Tile tile = new Tile(TileNumber);
                    board[row, column] = tile;
                    Console.Write($"{ tile.Position }");
                    TileNumber += 1;

                }
                Console.WriteLine();
            }

            Console.WriteLine($"board: {board}");
            Console.WriteLine($"board[0,0]: {board[0, 0]}");
            return board;
        }

        /// <summary>
        /// Pretty Prints out the board
        /// </summary>
        public void printBoard()
        {
            Console.WriteLine("printBoard!");
            for(int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    if (column != board.GetLength(1) - 1)
                    {
                    Console.Write($"{board[row, column].Value}|");
                    }
                    else
                    {
                    Console.Write($"{board[row, column].Value}");
                    }
                }
                Console.WriteLine();
            }
        }

        // tile1, "x"
        public void SetTileValue(int x, int y, string value)
        {
            board[x,y].Value = value;
        }

        //public void MapKeyValuesToKeyboardInput()
    }

}
