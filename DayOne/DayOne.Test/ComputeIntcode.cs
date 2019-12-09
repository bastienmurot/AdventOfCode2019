namespace DayOne.Test
{
    using Xunit;

    public class ComputeIntCodes
    {
        [Fact]
        public void ItExists()
        {
            var intcode = new Intcode("1,0,0,3,99");
            int result = intcode.Compute();
        }

        [Fact]
        public void GivenAnEmptyOpcodeSetShouldReturnValuesOfZero()
        {
            // Arrange
            var intcode = new Intcode("99");

            // Act
            int result = intcode.Compute();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenAnAddSetOfOpcodeShouldReturnValuesOfTwo()
        {
            // Arrange
            var intcode = new Intcode("1, 0, 0, 99");

            // Act
            int result = intcode.Compute();

            // Assert
            Assert.Equal(2, result);
        }
    }
}