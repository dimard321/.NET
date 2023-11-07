using AutoFixture;
using System.Numerics;
using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса LargeNumber
    /// </summary>
    public class LargeNumberTests
    {
        /// <summary>
        /// Объект Fixture для генерации случайных данных.
        /// </summary>
        private readonly IFixture _fixture;

        /// <summary>
        /// Инициализирует экземпляр класса LargeNumberTests с заданным логгером
        /// </summary>
        /// <param name="logger">Логгер для записи событий и ошибок</param>
        public LargeNumberTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void LargeNumbers_ShouldSumTwoLargeNumbers()
        {
            //Arrange
            var number1 = _fixture.Create<BigInteger>().ToString();
            var number2 = _fixture.Create<BigInteger>().ToString();
            var expectedResult = number1 + number2;

            //Act
            var result = LargeNumber.LargeNumbers(number1, number2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("*", "*")]
        [InlineData(".", ".")]
        [InlineData(",", ",")]
        [InlineData("?", "?")]
        [InlineData("/", "/")]
        [InlineData("-", "-")]
        [InlineData("", "")]
        public void LargeNumbers_ShouldThrowExceptionForInvalidCharsInFirstArgument(string number1, string number2)
        {
            //Arrange
            var result = LargeNumber.LargeNumbers(number1, number2);

            //Act&Assert
            Assert.Throws<FormatException>(() => LargeNumber.LargeNumbers(number1, number2));
        }
        [Fact]
        public void LargeNumbers_ShouldThrowArgumentNullExceptionForNullArgument()
        {
            //Arrangenull
            string number1 = null;
            var number2 = _fixture.Create<BigInteger>().ToString();

            //Act&Assert
            Assert.Throws<ArgumentNullException>(() => LargeNumber.LargeNumbers(number1, number2));
        }
    }
}
