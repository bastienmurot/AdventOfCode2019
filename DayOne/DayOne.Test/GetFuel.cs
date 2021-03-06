namespace DayOne.Test
{
    using DayOne;

    using Xunit;

    public class GetFuel
    {
        [Fact]
        public void GivenAMassShouldReturnNecessaryFuel()
        {
            // Arrange
            int mass = 1;

            // Act & Assert
            int result = Calculator.GetFuel(mass);
        }

        [Fact]
        public void GivenAMassOfTwelveShouldReturnTwoUnitsOfFuel()
        {
            // Arrange
            int mass = 12;

            // Act
            int result = Calculator.GetFuel(mass);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenAMassOfFourteenShouldReturnTwoUnitsOfFuel()
        {
            // Arrange
            int mass = 14;

            // Act
            int result = Calculator.GetFuel(mass);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void GivenAMassOf1969ShouldReturns966UnitsOfFuel()
        {
            // Arrange
            int mass = 1969;

            // Act
            int result = Calculator.GetFuel(mass);

            // Assert
            Assert.Equal(966, result);
        }

        [Fact]
        public void GivenAMassOf100756ShouldReturns50346UnitsOfFuel()
        {
            // Arrange
            int mass = 100756;

            // Act
            int result = Calculator.GetFuel(mass);

            // Assert
            Assert.Equal(50346, result);
        }
    }
}
