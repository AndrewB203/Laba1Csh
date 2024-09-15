namespace Laba1_3
{
    public class Point
    {
        private int x;
        private int y;

        public int X => x;
        public int Y => y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Figure
    {
        private Point[] points;
        public string Name { get; set; }

        public Figure(string name, params Point[] points)
        {
            if (points.Length < 3 || points.Length > 5)
            {
                throw new ArgumentException("Figure must have between 3 and 5 points.");
            }
            this.Name = name;
            this.points = points;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
            }
            return perimeter;
        }
    }
}
