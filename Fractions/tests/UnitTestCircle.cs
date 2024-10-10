using System.Reflection.Emit;

namespace tests
{
    public class UnitTestCircle
    {
        [Fact]
        public void Can_Instanciate_Circle()
        {
            // Arrange
            double radius = 22;
            Circle circle;

            // Acts
            circle = new Circle(radius);

            // Assert
            Assert.NotNull(circle);
        }

        [Fact]
        public void Can_Get_Correct_CirclePerimeter()
        {
            // Arrange
            double radius = 22;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.Perimeter();
            double expectedResult = 2 * Math.PI * radius;

            // Assert
            Assert.NotNull(circle);
            Assert.Equal(result, expectedResult);
            Assert.Equal(result, (radius * 2) * Math.PI);
            Assert.Equal(result, 2 * radius * Math.PI);
            Assert.Equal(result, 2 * (radius * Math.PI));
        }

        [Fact]
        public void CircleAreaTest()
        {
            // Arrange
            double radius = 22;
            Circle circle = new Circle(radius);

            // Act
            double result = circle.Area();
            double expectedResult = radius * radius * Math.PI;

            // Assert
            Assert.NotNull(circle);
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void CircleToStringTest()
        {
            // Arrange
            double radius = 22;
            Circle circle = new Circle(radius);

            // Act
            string? result = circle.ToString();
            string expectedResult = $"techmath.Circle({radius})";
            
            // Assert
            Assert.NotNull(circle);
            Assert.Equal(result, expectedResult);
        }
    }
}