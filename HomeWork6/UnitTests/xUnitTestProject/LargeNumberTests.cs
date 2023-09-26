using UnitTests;

namespace xUnitTestProject
{
    /// <summary>
    /// Класс c тестами для класса LargeNumber
    /// </summary>
    public class LargeNumberTests
    {
        
        [Fact]
        public void LargeNumbers_ShouldSumTwoPositiveLargeNumbers()
        {
            //Arrange
            string number1 = "25348790128379128937";
            string number2 = "89787987565648734565";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("115136777694027863502", result);
        }

        [Fact]
        public void LargeNumbers_ShouldSumTwoNegativeLargeNumbers()
        {
            //Arrange
            string number1 = "-25348790128379128937";
            string number2 = "-89787987565648734565";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("-115136777694027863502", result);
        }

        [Fact]
        public void LargeNumbers_ShouldSumPositiveAndNegativeLargeNumbers()
        {
            //Arrange
            string number1 = "25348790128379128937";
            string number2 = "-89787987565648734565";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("-64439197437269605628", result);
        }

        [Fact]
        public void LargeNumbers_ShouldSumNegativeAndPositiveLargeNumbers()
        {
            //Arrange
            string number1 = "-25348790128379128937";
            string number2 = "89787987565648734565";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("64439197437269605628", result);
        }

        [Fact]
        public void LargeNumbers_ShouldProcessingZeroInSecondArgument()
        {
            //Arrange
            string number1 = "25348790128379128937";
            string number2 = "0";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("25348790128379128937", result);
        }

        [Fact]
        public void LargeNumbers_ShouldProcessingZeroInFirstArgument()
        {
            //Arrange
            string number1 = "0";
            string number2 = "89787987565648734565";
            //Act
            string result = LargeNumber.LargeNumbers(number1, number2);
            //Assert
            Assert.Equal("89787987565648734565", result);
        }

        [Fact]
        public void LargeNumbers_ShouldThrowExceptionForInvalidCharsInFirstArgument()
        {
            //Arrange
            string number1 = "2534.87-90,328379128937"; 
            string number2 = "89787987565648734565";
            //Act&Assert
            Assert.Throws<FormatException>(() => LargeNumber.LargeNumbers(number1, number2));
        }

        [Fact]
        public void LargeNumbers_ShouldThrowArgumentNullExceptionForNullArgument()
        {
            //Arrangenull
            string number1 = null;
            string number2 = "25348790328379128937";
            //Act&Assert
            Assert.Throws<ArgumentNullException>(() => LargeNumber.LargeNumbers(number1, number2));
        }
    }
}
