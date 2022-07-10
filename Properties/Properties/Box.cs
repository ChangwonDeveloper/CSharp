using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        // member variable
        private int length = 3;
        private int height;
        private int width;
        private int volume;
        // default getter and setter
        public int Width { get; set; }
        public int Volume
        {
            get
            { return length*height*width; }
        }

        public int Height
        {
            get { return height; }

            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;

                }
            }
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength() { return length; }

        public int GetVolume()
        {
            return length * height * width;
        }

        public Box(int length, int height, int width)
        {
            this.length= length;
            this.height = height;
            this.width = width;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}"
                , length, height, width, volume = length*height*width);
        }
    }
}