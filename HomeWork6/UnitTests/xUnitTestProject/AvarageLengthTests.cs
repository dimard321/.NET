using AutoFixture;
using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// ����� � ������� ��� ������ AverageLength
    /// </summary>
    public class AverageLengthTests
    {
        /// <summary>
        /// ������ Fixture ��� ��������� ��������� ������.
        /// </summary>
        private readonly IFixture _fixture;

        /// <summary>
        /// �������������� ��������� ������ AverageLengthTests � �������� ��������
        /// </summary>
        /// <param name="logger">������ ��� ������ ������� � ������</param>
        public AverageLengthTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void ShouldCalculateAverageLength()
        {
            //Arrange
            var text = _fixture.Create<string>().ToString();
            var expected = text.Split(' ').Average(word => word.Length);
            // Act
            var result = AverageLength.CalculateAverageLength(text);
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
