using System;

namespace Method
{
    class Point
    {
        // Private fields => _camelCase
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public void Move(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            this.Move(newLocation._x, newLocation._y);
        }
    }
}
