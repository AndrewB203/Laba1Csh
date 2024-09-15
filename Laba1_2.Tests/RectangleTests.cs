using Xunit;

namespace Laba1_2.Tests
{
    public class RectangleTests
    {
        [Fact]
        public void CalculateArea_ShouldReturnCorrectArea()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(5, 10);

            // Act
            double area = rectangle.Area;

            // Assert
            Assert.Equal(50, area);
        }

        [Fact]
        public void CalculatePerimeter_ShouldReturnCorrectPerimeter()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(5, 10);

            // Act
            double perimeter = rectangle.Perimeter;

            // Assert
            Assert.Equal(30, perimeter);
        }
    }
}