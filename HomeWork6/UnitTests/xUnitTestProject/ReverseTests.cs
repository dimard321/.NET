using AutoFixture;
using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса ReverseWords
    /// </summary>
    public class ReverseTests
    {
        /// <summary>
        /// Объект Fixture для генерации случайных данных.
        /// </summary>
        private readonly IFixture _fixture;

        /// <summary>
        /// Инициализирует экземпляр класса ReverseTests с заданным логгером
        /// </summary>
        /// <param name="logger">Логгер для записи событий и ошибок</param>
        public ReverseTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void Reverse_ShouldReverseWordsInSentence()
        {
            //Arrange
            var sentence = _fixture.Create<string>().ToString();
            var expected = Reverse.ReverseWords(sentence);

            // Act
            var result = Reverse.ReverseWords(sentence);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reverse_ShouldThrowArgumentNullExceptionForNullArgument()
        {
            // Arrange
            string sentence = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Reverse.ReverseWords(sentence));
        }
    }
}
