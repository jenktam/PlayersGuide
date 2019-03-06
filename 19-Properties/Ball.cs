//TIO: CH 19 - PG 129. Ball and Color with Properties
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Properties
{

    public class Ball
    {
        /// <summary>
        /// Size only get because write-only
        /// </summary>
        public float Size { get; set; }
        public Color Color { get; set; }
        private int timesThrown;

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            timesThrown = 0;
        }

        public float Pop()
        {
            return Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
               timesThrown += 1; // why not this.timesThrown?
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }

    }
}
