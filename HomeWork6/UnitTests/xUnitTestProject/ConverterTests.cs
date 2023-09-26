using Moq;
using NLog;
using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса Converter
    /// </summary>
    public class ConverterTests
    {
        /// <summary>
        /// Логгер для записи событий и ошибок
        /// </summary>
        private readonly Mock<ILogger> _logger;

        /// <summary>
        /// Инициализирует экземпляр класса ConverterTests с заданным логгером
        /// </summary>
        /// <param name="logger">Логгер для записи событий и ошибок</param>
        public ConverterTests()
        {
            _logger = new Mock<ILogger>();
        }

        [Theory]
        [InlineData("2345435432342342342", 2345435432342342342)]
        [InlineData("-4563243423423457675", -4563243423423457675)]
        [InlineData("0", 0)]
        public void Convert_ShouldConvertStringToInt(string inputString, int expectedResult)
        {

            var Converter = new Converter(_logger.Object);
            // Act
            var result = Converter.Convert(inputString);
            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("12a")]
        [InlineData("abc")]
        [InlineData("1.23")]
        public void Convert_ShouldThrowFormatExceptionForInvalidInput(string inputString)
        {
            // Arrange
            var converter = new Converter(_logger.Object);
            // Act & Assert
            Assert.Throws<FormatException>(() => converter.Convert(inputString));
        }

        [Fact]
        public void Convert_ShouldThrowArgumentNullExceptionForNullInput()
        {
            //Arrange
            var converter = new Converter(_logger.Object);
            //Act&Assert
            Assert.Throws<ArgumentNullException>(() => converter.Convert(null));
        }
    }
}

