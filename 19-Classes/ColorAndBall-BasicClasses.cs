/* 
    * TIO: Pg 123: Ch 19      
    * Create color class
    * Create ball class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Classes
{
    class ColorAndBall
    {
        static void Main(string[] args)
        {

            Color newColor = new Color(0, 10, 200, 100);
            //Console.WriteLine($"newColor.red: {newColor.red}"); // can't log
            Console.WriteLine($"newColor.getColorValue(red) 0: {newColor.getColorValue("red")}");
            newColor.setColorValue("red", 10);
            newColor.getColorValue("red");
            Console.WriteLine($"newColor.getColorValue(red) 1: {newColor.getColorValue("red")}");

            newColor.getGrayScaleValue();
            Console.WriteLine($"newColor.getGrayScaleValue() { newColor.getGrayScaleValue() }");

            Color black = new Color(255, 255, 255);


            Ball newBall = new Ball(10, black);
            Console.WriteLine($"newBall.GetBallSize() 0: {newBall.GetBallSize()}"); // should be 10
            Console.WriteLine($"newBall.GetTimesThrown 0: {newBall.GetTimesThrown()}");
            newBall.Throw();
            Console.WriteLine($"newBall.Throw() called");
            Console.WriteLine($"newBall.GetTimesThrown 1: {newBall.GetTimesThrown()}");

            newBall.Throw();
            Console.WriteLine($"newBall.Throw() called");
            Console.WriteLine($"newBall.GetTimesThrown 1: {newBall.GetTimesThrown()}");

            newBall.Pop();
            Console.WriteLine($"newBall.GetBallSize() 1: {newBall.GetBallSize()}"); // should be 0

            Console.ReadKey();

            /*
                TIO Quiz:
                    1. T - Classes are reference types.
                    2.  Classes - define what a particular type of thing can do and store.
                        Instance - a specific object that contains it's own set of data.
                    3. 3 types of members that can be part of a class: Constructor(public so accessible from outside class) , instance variables(private), and methods(public)
                    4. T - If something is static, it is shared by all instances of a particular type.
                    5. A Constructor!! - Special type of method that sets up a new instance.
                    6. private - can be accessed only within the class
                    7. public - can be accessed from anywhere
                    8. internal - accessed anywhere inside of the project it is contained in.
            */
        }
    }

    /// <summary>
    /// Represents color as red, green , blue and alpha components.
    /// </summary>
    public class Color
    {
        /// <summary>
        /// Stores colors
        /// </summary>
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        // Constructor
        /// <summary>
        ///  Creates a new color with all of the components specified
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <param name="alpha"></param>
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha; // defaults to 255
        }


        /// <summary>
        /// Creates a new color with only red, green and blue if only params. In this case, defaults alpha to 255(opaque).
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255; // defaults to 255
        }

        public byte getColorValue(string colorName)
        {

            //switch(colorName)
            //{
            //    case "red":
            //        return red;
            //    case "green":
            //        return green;
            //    case "blue":
            //        return blue;
            //    case "alpha":
            //        return alpha;
            //    //default:
            //    //    Console.WriteLine("Error: Didn't provide a valid color name.");
            //    //    return;
            //    //    break;
            //}

            if(colorName == "red")
            {
                return red;
            } else if (colorName == "green")
            {
                return green;
            } else if (colorName == "blue")
            {
                return blue;
            } else if (colorName == "alpha")
            {
                return alpha;
            } else
            {
                return 0;
            }
        }

        // these instance methods are public because they can be called insie and outside the Color class
        public void setColorValue(string colorName, byte value)
        {
            switch(colorName)
            {
                case "red":
                    this.red = value;
                    break;
                case "green":
                    this.green = value;
                    break;
                case "blue":
                    this.blue = value;
                    break;
                case "alpha":
                    this.alpha = value;
                    break;
                default:
                    Console.WriteLine("Error: The color value you are attempting to change doesn't exist in this class.");
                    break;
            }
        }

        /// <summary>
        /// Returns grayscale value of this color
        /// </summary>
        /// <returns></returns>
        public byte getGrayScaleValue()
        {
            //this ensures result is casts to byte (byte)
            return (byte)((red + green + blue) / 3);
        }
    }

    class Ball
    {
        /// <summary>
        /// radius/size should be in generic decimal units
        /// </summary>
        private float size;
        private Color color;
        private int timesBallThrown;

        /// <summary>
        /// Constructor for creating a new ball with given size and color;
        /// </summary>
        /// <param name="size"></param>
        /// <param name="color"></param>
        public Ball(float size, Color color)
        {
            this.size = size;
            this.color = color;
            this.timesBallThrown = 0; // this starts at 0 every time we create a new ball instance
        }

        public void Pop()
        {
            this.size = 0;
        }

        public void Throw()
        {
            if(this.size != 0)
            {
                this.timesBallThrown += 1;
            }
        }

        public int GetTimesThrown()
        {
            return this.timesBallThrown;
        }

        public float GetBallSize()
        {
            return size;
        }
    }
}
