//TIO: CH 19 - PG 129. Ball and Color with Properties
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color(0, 20, 40, 60);
            //color.Red = 0;
            //Color color = new Color() { Red = 0, Green = 10, Blue = 10, Alpha = 10 };
            Console.WriteLine($"color.Red0: {color.Red}");
            color.Red = 20;
            color.Red.GetType();
            Console.WriteLine($"color.Red.GetType();: {color.Red.GetType()}");
            Console.WriteLine($"color.Red1: {color.Red}");

            Color color2 = new Color(0, 20, 40);
            //color.Red = 0;
            //Color color = new Color() { Red = 0, Green = 10, Blue = 10, Alpha = 10 };
            Console.WriteLine($"color.Red0: {color2.Red}");
            color2.Red = 20;
            color2.Red.GetType();
            Console.WriteLine($"color2.Red.GetType();: {color2.Red.GetType()}");
            Console.WriteLine($"color2.Red1: {color2.Red}");
            Console.WriteLine($"color2.Alpha: {color2.Alpha}");
            Console.WriteLine($"GetGrayscale: {color2.GetGrayscale()}");

            Ball ball = new Ball(5, color);

            //Color color = new Color() { Red = 0, Green = 10, Blue = 10, Alpha = 10 };
            Console.WriteLine($"ball.Size0: {ball.Size}");
            color2.Red = 20;
            ball.Throw();
            ball.Throw();
            Console.WriteLine($"ball.GetTimesThrown() 0: {ball.GetTimesThrown()}");
            Console.WriteLine($"ball.Color 0: {ball.Color}");
            ball.Pop();
            Console.WriteLine($"ball.Size1: {ball.Size}");




            Console.ReadKey();

        }
    }

    public class Color
    {
        // Instance Variables
        /// <summary>
        /// Non-auto implemented property
        /// </summary>
        private byte red;
        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value;
            }
        }

        /// <summary>
        /// auto-implemented getters/setters
        /// </summary>
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public byte GetGrayscale()
        {
            return (byte)((Red + Green + Blue) / 3);
        }

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

    }
}
