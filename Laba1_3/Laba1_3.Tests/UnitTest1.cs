using Xunit;
using Laba1_3;

namespace Laba1_3.Tests
{
    public class FigureTests
    {
        /*[Fact]
        public void TestLengthSide()
        {
            Point A = new Point(0, 0);
            Point B = new Point(4, 0);
            Figure figure = new Figure("Test", A, B);

            double length = figure.LengthSide(A, B);
            Assert.Equal(4, length, 3); // 3 - это количество знаков после запятой для сравнения
        }*/

        [Fact]
        public void TestPerimeterCalculatorTriangle()
        {
            Point A = new Point(0, 0);
            Point B = new Point(4, 0);
            Point C = new Point(4, 3);
            Figure triangle = new Figure("Triangle", A, B, C);

            double perimeter = triangle.PerimeterCalculator();
            Assert.Equal(12, perimeter, 3);
        }

        [Fact]
        public void TestPerimeterCalculatorSquare()
        {
            Point A = new Point(0, 0);
            Point B = new Point(4, 0);
            Point C = new Point(4, 4);
            Point D = new Point(0, 4);
            Figure square = new Figure("Square", A, B, C, D);

            double perimeter = square.PerimeterCalculator();
            Assert.Equal(16, perimeter, 3);
        }

        /*[Fact]
        public void TestPerimeterCalculatorPentagon()
        {
            Point A = new Point(0, 0);
            Point B = new Point(4, 0);
            Point C = new Point(6, 3);
            Point D = new Point(3, 5);
            Point E = new Point(0, 3);
            Figure pentagon = new Figure("Pentagon", A, B, C, D, E);

            double perimeter = pentagon.PerimeterCalculator();
            Assert.Equal(18.526, perimeter, 3);
        }*/

        [Fact]
        public void TestInvalidFigure()
        {
            Point A = new Point(0, 0);
            Point B = new Point(4, 0);

            Assert.Throws<ArgumentException>(() => new Figure("Invalid", A, B));
        }
    }
}