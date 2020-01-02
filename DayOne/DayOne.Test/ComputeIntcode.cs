namespace DayOne.Test
{
    using Xunit;

    public class ComputeIntCodes
    {
        [Fact]
        public void ItExists()
        {
            int[] intcodes = new int[] { 1, 0, 0, 3, 99 };

            var intcode = new Intcode(intcodes);
            int result = intcode.Compute();
        }

        [Fact]
        public void GivenAnEmptyOpcodeSetShouldReturnValuesOfZero()
        {
            // Arrange
            int[] intcodes = new int[] { 99 };
            var intcode = new Intcode(intcodes);

            // Act
            int result = intcode.Compute();

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void GivenAnAddSetOfOpcodeShouldReturnValuesOfTwo()
        {
            // Arrange
            int[] intcodes = new int[] { 1, 0, 0, 3, 99 };
            var intcode = new Intcode(intcodes);

            // Act
            int result = intcode.Compute();

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenAnAddComplexSetOfOpcodeShouldReturnValuesOf3500()
        {
            // Arrange
            int[] intcodes = new int[] { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            var intcode = new Intcode(intcodes);

            // Act
            int result = intcode.Compute();

            // Assert
            Assert.Equal(3500, result);
        }
    }
}