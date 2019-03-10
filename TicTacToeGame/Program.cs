using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Position> hash = new Dictionary<string, Position>();
            MapKeyboardInputToPosition();

            // Set up board logistics and pass over to game controller
            Board newBoard = new Board();
            Player Player1 = new Player("x");
            Player Player2 = new Player("o");
            GameController gameController = new GameController(newBoard);

            Console.WriteLine("***Welcome to the Tic Tac Toe Game!***");
            gameController.StartGame();
            gameController.EnterGamePlay(Player1.IconType, Player2.IconType, hash);
            
            // After winner determined reset game
            RestartGame();


            Console.ReadKey();

            // Uses a dictionary to map keyboard inputs 1-9 to a position
            void MapKeyboardInputToPosition()
            {
                //map keyboard input to board location
                hash.Add("NumPad7", new Position(0, 0));
                hash.Add("NumPad8", new Position(0, 1));
                hash.Add("NumPad9", new Position(0, 2));
                hash.Add("NumPad4", new Position(1, 0));
                hash.Add("NumPad5", new Position(1, 1));
                hash.Add("NumPad6", new Position(1, 2));
                hash.Add("NumPad1", new Position(2, 0));
                hash.Add("NumPad2", new Position(2, 1));
                hash.Add("NumPad3", new Position(2, 2));

                //Console.WriteLine($"hash {hash}");
                //Console.WriteLine($"hash[NumPad7] {hash["NumPad7"]}");

            }

            void RestartGame()
            {
                Console.WriteLine("Would you like to restart the game? Press y or n to continue...");
                string restartGame = Console.ReadLine();


                if (restartGame == "y")
                {
                    newBoard.winner = "";
                    gameController.StartGame();
                    gameController.EnterGamePlay(Player1.IconType, Player2.IconType, hash);
                    RestartGame(); // just call this method again and restart game if user enters "y".
                }
                else if(restartGame == "n")
                {
                    Console.WriteLine("Tic tac toe game is over. Thanks for playing.");
                    Console.WriteLine("exiting...");
                    return;
                } else
                {
                    Console.WriteLine("Invalid string. Please only choose y or n.");
                    RestartGame();
                }

            }
        }
    }
}