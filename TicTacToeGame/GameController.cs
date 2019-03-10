using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class GameController
    {
        /* 
         * fn: start game - create new board and wait for player inputs. after each input check if there's a winner. if winner, end game
         * 
         */
        //public Board GCBoard = new Board();
        //GCBoard.CreateBoard();

        //public GameController()
        //{
        //    GCBoard = board;
        //}

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Board GCBoard { get; set; }
        //Creates dictionary with the keyboard input and the position coordinates
        Dictionary<string, Position> hash = new Dictionary<string, Position>();

        public GameController(Board Board)
        {
            GCBoard = Board;
        }

        public void StartGame()
        {
            Player Player1 = new Player("x");
            Player Player2 = new Player("o");

            GCBoard.CreateBoard(); // must set this first otherwise get instance errors. fix this!
            //GCBoard.PrintBoard();



        }

        public void EnterGamePlay(string player1Icon, string player2Icon, Dictionary<string, Position> hash)
        {
            while (GCBoard.winner == "")
            {
                MapKeyboardAction(player1Icon, hash); // p1

                if(GCBoard.winner == "")
                {
                    MapKeyboardAction(player2Icon, hash); // p2
                }
            }
        }

        // Maps user's key input to board position
        // Can only put in NumPad0-9, anything else is invalid and should throw a warning
        void MapKeyboardAction(string playerIcon, Dictionary<string, Position> hash)
        {
            Console.WriteLine($"Player Turn: {playerIcon}");
            string key = "";

            key = Console.ReadKey().Key.ToString();
            Console.WriteLine("key1: " + key);

            foreach (KeyValuePair<string, Position> pair in hash)
            {
                if (key == pair.Key)
                {
                    // Checks if tile has values already
                    if (GCBoard.board[pair.Value.X, pair.Value.Y].Value == "x" || GCBoard.board[pair.Value.X, pair.Value.Y].Value == "o")
                    {
                        Console.WriteLine("*****");
                        Console.WriteLine("This tile was already selected, choose another tile.");
                        Console.WriteLine("*****");

                    }
                    else
                    {
                        GCBoard.SetTileValue(pair.Value.X, pair.Value.Y, playerIcon);
                    }
                    GCBoard.PrintBoard();
                    DetermineWinner();
                }
                else
                {
                    //Console.WriteLine("*****");
                    //Console.WriteLine($"{key} is an invalid input. Please only select the numPad numbers 1 through 9.");
                    //Console.WriteLine("*****");
                }
            }
            return;
        }

        void DetermineWinner()
        {
            if ((GCBoard.board[0, 0].Value == "x"
                && GCBoard.board[0, 1].Value == "x"
                && GCBoard.board[0, 2].Value == "x")
                ||
                (GCBoard.board[1, 0].Value == "x"
                && GCBoard.board[1, 1].Value == "x"
                && GCBoard.board[1, 2].Value == "x")
                ||
                (GCBoard.board[2, 0].Value == "x"
                && GCBoard.board[2, 1].Value == "x"
                && GCBoard.board[2, 2].Value == "x")
                ||
                (GCBoard.board[0, 0].Value == "x"
                && GCBoard.board[1, 1].Value == "x"
                && GCBoard.board[2, 2].Value == "x")
                ||
                (GCBoard.board[0, 2].Value == "x"
                && GCBoard.board[1, 1].Value == "x"
                && GCBoard.board[2, 0].Value == "x")
                ||
                (GCBoard.board[0, 0].Value == "x"
                && GCBoard.board[1, 0].Value == "x"
                && GCBoard.board[2, 0].Value == "x")
                ||
                (GCBoard.board[0, 1].Value == "x"
                && GCBoard.board[1, 1].Value == "x"
                && GCBoard.board[2, 1].Value == "x")
                ||
                (GCBoard.board[0, 2].Value == "x"
                && GCBoard.board[1, 2].Value == "x"
                && GCBoard.board[2, 2].Value == "x")
                )
            {
                Console.WriteLine("Player 1 - x wins!");
                GCBoard.winner = "x";
            }
            else if (
              (GCBoard.board[0, 0].Value == "o"
              && GCBoard.board[0, 1].Value == "o"
              && GCBoard.board[0, 2].Value == "o")
              ||
              (GCBoard.board[1, 0].Value == "o"
              && GCBoard.board[1, 1].Value == "o"
              && GCBoard.board[1, 2].Value == "o")
              ||
              (GCBoard.board[2, 0].Value == "o"
              && GCBoard.board[2, 1].Value == "o"
              && GCBoard.board[2, 2].Value == "o")
              ||
              (GCBoard.board[0, 0].Value == "o"
              && GCBoard.board[1, 1].Value == "o"
              && GCBoard.board[2, 2].Value == "o")
              ||
              (GCBoard.board[0, 2].Value == "o"
              && GCBoard.board[1, 1].Value == "o"
              && GCBoard.board[2, 0].Value == "o")
              ||
              (GCBoard.board[0, 0].Value == "o"
              && GCBoard.board[1, 0].Value == "o"
              && GCBoard.board[2, 0].Value == "o")
              ||
              (GCBoard.board[0, 1].Value == "o"
              && GCBoard.board[1, 1].Value == "o"
              && GCBoard.board[2, 1].Value == "o")
              ||
              (GCBoard.board[0, 2].Value == "o"
              && GCBoard.board[1, 2].Value == "o"
              && GCBoard.board[2, 2].Value == "o")
              )
            {
                Console.WriteLine("Player 2 - o wins!");
                GCBoard.winner = "o";
            }
            //else
            //{
            //    Console.WriteLine("No winner yet!");
            //}

        }


    }
}
