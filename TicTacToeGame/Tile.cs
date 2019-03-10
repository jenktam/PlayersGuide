using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Tile
    {
        public Position Position { get; set; }
        public string Value { get; set; }
  
        public Tile(int row, int column, string value)
        {
            Position = new Position(row, column);
            Value = value;
        }

        public Tile(int row, int column)
        {
            Position = new Position(row, column);
            Value = " ";
        }

    }
}
