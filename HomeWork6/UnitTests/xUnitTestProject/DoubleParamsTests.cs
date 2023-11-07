using AutoFixture;
using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса DoubleParams
    /// </summary>
    public class DoubleParamsTests
    {
        /// <summary>
        /// Объект Fixture для генерации случайных данных.
        /// </summary>
        private readonly IFixture _fixture;

        /// <summary>
        /// Инициализирует экземпляр класса DoubleParamsTests с заданным логгером
        /// </summary>
        /// <param name="logger">Логгер для записи событий и ошибок</param>
        public DoubleParamsTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void DoubleParameters_ShouldDoubleChars()
        {
            //Arrange
            var input = _fixture.Create<string>().ToString();
            var charactersToDouble = _fixture.Create<string>().ToString();
            var expectedResult = input;
            foreach (var character in charactersToDouble)
            {
                expectedResult = expectedResult.Replace(character.ToString(), character.ToString() + character.ToString());
            }

            //Act
            var result = DoubleParams.DoubleParameters(input, charactersToDouble);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void DoubleParameters_ShouldProcessingeNullInputString()
        {
            //Arrange
            string input = null;
            var charactersToDouble = _fixture.Create<string>().ToString();

            //Act&Assert
            Assert.Throws<ArgumentNullException>(() => AverageLength.CalculateAverageLength(DoubleParams.DoubleParameters(input, charactersToDouble)));
        }
    }
}
