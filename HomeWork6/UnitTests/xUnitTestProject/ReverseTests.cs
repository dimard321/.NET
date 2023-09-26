using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса ReverseWords
    /// </summary>
    public class ReverseTests
    {
        [Theory]
        [InlineData("Killer killua", "killua Killer")]
        [InlineData("Killua", "Killua")]
        [InlineData("Killer   killua", "killua   Killer")]
        [InlineData("", "")]
        [InlineData("  Killer killua  ", "  killua Killer  ")]
        [InlineData("Killer, killua. He killed him.", ".him killed He. killua ,Killer")]
        [InlineData("Killer Killua@mail.ru", "Killua@mail.ru Killer")]
        public void ShouldReverseWordsInSentence(string sentence, string expected)
        {
            // Act
            string result = Reverse.ReverseWords(sentence);
            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldThrowArgumentNullExceptionForNullArgument()
        {
            // Arrange
            string sentence = null;
            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => Reverse.ReverseWords(sentence));
        }
    }
}
