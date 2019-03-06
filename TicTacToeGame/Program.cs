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
            Board newBoard = new Board();

            //Creates dictionary with the keyboard input and the position coordinates
            Dictionary<string, Position> hash = new Dictionary<string, Position>();

            newBoard.CreateBoard();
            //newBoard.SetTileValue(0, 0, "x");
            //newBoard.SetTileValue(2, 1, "o");
            //newBoard.SetTileValue(2, 2, "o");
            //newBoard.PrintBoard();
            MapKeyboardInputToPosition();
            MapKeyboardAction();

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

                Console.WriteLine($"hash {hash}");

                //// Loop over items in collection.
                foreach (KeyValuePair<string, Position> pair in hash)
                {
                    Console.WriteLine("KEY: " + pair.Key);
                    Console.WriteLine("VALUE: " + pair.Value.X);
                    Console.WriteLine("VALUE: " + pair.Value.Y);
                }
            }

            // User key input should map to position
            // Can only put in NumPad0-9, anything else is invalid and should throw a warning
            void MapKeyboardAction()
            {
                string key = "";

                while (key != "Q")
                {
                    key = Console.ReadKey().Key.ToString();
                    Console.WriteLine("key: " + key);

                    foreach (KeyValuePair<string, Position> pair in hash)
                    {
                        if (key == pair.Key)
                        {
                            //key: numPad7 pair.Key: numPad7
                            Console.WriteLine("match KEY: " + pair.Key);
                            Console.WriteLine("VALUE: " + pair.Value.X);
                            Console.WriteLine("VALUE: " + pair.Value.Y);
                        }
                        else
                        {
                            Console.WriteLine("no match!");
                        }
                    }
                }
                Console.WriteLine("exiting...");
                return;
            };

        }
    }
}