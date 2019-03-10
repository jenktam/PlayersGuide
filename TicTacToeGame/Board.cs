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
        public string winner;

        // constructor
        public Board()
        {
            board = board;
            winner = "";
        }

        public Tile[,] CreateBoard()
        {
            //Iterates until row < length of 1st number in the matrix
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int column = 0; column < board.GetLength(1); column++)
                {
                    Tile tile = new Tile(row, column);
                    board[row, column] = tile;
                }
            }

            return board;
        }

        /// <summary>
        /// Pretty Prints out the board
        /// </summary>
        public void PrintBoard()
        {
            //Console.WriteLine("printBoard!");
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

        public void SetTileValue(int x, int y, string value)
        {
            board[x,y].Value = value;
        }
    }

}
