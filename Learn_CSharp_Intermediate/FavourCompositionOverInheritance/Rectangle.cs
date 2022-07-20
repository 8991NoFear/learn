using System;

namespace FavourCompositionOverInheritance
{
    class Rectangle : Shape
    {
        private int _height;
        private int _width;

        public int Width 
        { 
            get
            {
                return _width;
            }

            set
            {
                if (_width < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than or equalt to 0");
                }
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (_height < 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than or equalt to 0");
                }
            }
        }

        public Rectangle()
        {

        }

        public Rectangle(int Width, int Height)
            : this()
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override int CaculateArea()
        {
            return Width * Height;
        }
    }
}
