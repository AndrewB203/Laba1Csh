using System;

namespace Laba1_3
{
class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(0, 0);
        Point B = new Point(4, 0);
        Point C = new Point(4, 3);

        Figure triangle = new Figure("Triangle", A, B, C);

        Console.WriteLine($"Figure: {triangle.Name}");
        Console.WriteLine($"Perimeter: {triangle.PerimeterCalculator()}");
    }
}

}
