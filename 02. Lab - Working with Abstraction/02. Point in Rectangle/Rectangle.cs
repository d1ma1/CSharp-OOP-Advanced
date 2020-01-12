namespace PointInRectangle
{
    public class Rectangle
    {
        public Point Left { get; set; }
        public Point Right { get; set; }

        public Rectangle(Point left, Point right)
        {
            this.Left = left;
            this.Right = right;
        }

        public bool Contains(Point p)
        {
            var isInside = false;
            if (this.Left.X <= p.X && this.Right.X >= p.X && this.Left.Y <= p.Y && this.Right.Y >= p.Y)
            {
                isInside = true;
            }
            return isInside;
        }
    }
}
