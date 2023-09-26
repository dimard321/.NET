using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс с тестами для класса AverageLength
    /// </summary>
    public class AverageLengthTests
    {
        [Theory]
        [InlineData(null, 0)]
        [InlineData("Zxcursed", 8)]
        [InlineData("I can not stop", 2.7)]
        [InlineData("Hello, my name is Sasha! Ok.", 3.3)]
        [InlineData("The commission is 12 persent", 3.6)]
        [InlineData("The commission is 20% of $100. We send a check by mail qwerty@mail.ru", 3.4)]
        public void ShouldCalculateAverageLength(string text, double expected)
        {
            // Act
            double result = AverageLength.CalculateAverageLength(text);
            // Assert
            Assert.Equal(expected, result, precision: 1);
        }

        [Fact]
        public void CalculateAverageLength_ShouldThrowArgumentNullExceptionForNullText()
        {
            // Arrange
            string text = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => AverageLength.CalculateAverageLength(text));
        }
    }
}
