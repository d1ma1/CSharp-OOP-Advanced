using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public int Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                this.width = value;
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                this.height = value;
            }
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void Draw()
        {
            Console.WriteLine(new String('*', Width));

            for (int j = 0; j < Height-2; j++)
            {
                Console.Write('*');
                Console.Write(new String(' ', Width - 2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new String('*', Width));
        }
    }
}
