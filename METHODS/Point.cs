﻿namespace METHODS
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int y, int x)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newlocation)
        {
            this.X = newlocation.X;
            this.Y = newlocation.Y;
        }
    }
}
