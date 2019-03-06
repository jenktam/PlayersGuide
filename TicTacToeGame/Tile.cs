using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Tile
    {
        public int Position { get; set; }
        public string Value { get; set; }
  
        public Tile(int position, string value)
        {
            Position = position;
            Value = value;
        }

        public Tile(int position)
        {
            Position = position;
            Value = " ";
        }

    }
}
