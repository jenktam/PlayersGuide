using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Player
    {
        public string IconType { get; set; }
        public int Tile { get; set; }
        //public List<int> Board { get; set; }
        //public List<int> chosenTiles;

        //this needs work
        public Player(string iconType)
        {
            IconType = iconType;
            //Tile = tile;
            //this.chosenTiles = chosenTiles;
        }

        /// <summary>
        /// Methods
        /// </summary>
        /// <param name="tile"></param>
        //public void ChooseTile(int tile)
        //    {
        //        //1) Make sure tile is only within 1-9 range
        //        if (tile <= 0 || tile > 9)
        //        {
        //            Console.WriteLine("Must be tiles numbered 1 - 9 only.");
        //        }
        //        else if (tile > 0 && tile <= 9)
        //        {
        //            //2) Check if chosen tile is already full
        //            if (Board.UsedTiles.Contains(tile))
        //            {
        //                Console.WriteLine($"This tile was taken already. Board.takenTiles: {Board.UsedTiles}");
        //            }
        //            //3) If chosen tile is empty, add user's spot to it
        //            this.AddTileToChosenTilesList(tile);
        //        }
        //    }

        //public void AddTileToChosenTilesList(int tile)
        //    {
        //        chosenTiles.Add(tile);
        //    }
    }
}
