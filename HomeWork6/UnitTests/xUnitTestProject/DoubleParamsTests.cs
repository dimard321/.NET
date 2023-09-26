using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса DoubleParams
    /// </summary>
    public class DoubleParamsTests
    {
        [Fact]
        public void DoubleParameters_ShouldDoubleChars()
        {
            //Arrange
            var input = "Killua!";
            var charactersToDouble = "King";
            //Act
            var result = DoubleParams.DoubleParameters(input, charactersToDouble);
            //Assert
            Assert.Equal("KKiillua", result);
        }

        [Fact]
        public void DoubleParameters_ShouldNotDoubleSpaceChars()
        {
            //Arrange
            var input = "killer killua";
            var charactersToDouble = "king";
            //Act
            var result = DoubleParams.DoubleParameters(input, charactersToDouble);
            //Assert
            Assert.Equal("kkiiller kkiillua", result);
        }

        [Fact]
        public void DoubleParameters_ShouldProcessingEmptyCharsToDoubleString()
        {
            //Arrange
            var input = "killer  killua";
            var charactersToDouble = "";
            //Act
            var result = DoubleParams.DoubleParameters(input, charactersToDouble);
            //Assert
            Assert.Equal("killer  killua", result);
        }

        [Fact]
        public void DoubleParameters_ShouldProcessingeNullInputString()
        {
            //Arrange
            string input = null;
            var charactersToDouble = "king";
            //Act
            var result = DoubleParams.DoubleParameters(input, charactersToDouble);
            //Assert
            Assert.Throws<ArgumentNullException>(() => AverageLength.CalculateAverageLength(DoubleParams.DoubleParameters(input, charactersToDouble)));
        }
    }
}
