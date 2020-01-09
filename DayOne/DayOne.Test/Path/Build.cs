namespace DayOne.Test.Path
{
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class Build
    {
        [Fact]
        public void ItExists()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R8", "U5", "L5", "D3" };
            var path = new DayOne.Path(moves);

            // Act & Assert
            IEnumerable<(int, int)> points = path.Build();
        }

        [Fact]
        public void GivenARightWithOneUnitDirectionShouldReturnOneElementInList()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R1" };
            var path = new DayOne.Path(moves);

            // Act
            IEnumerable<(int, int)> result = path.Build();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal((1, 0), result.First());
        }

        [Fact]
        public void GivenARightWithTwoUnitDirectionShouldReturnTwoElementInList()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R2" };
            var path = new DayOne.Path(moves);

            // Act
            List<(int, int)> result = path.Build().ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal((1, 0), result[0]);
        }

        [Fact]
        public void GivenALeftWithOneUnitDirectionShouldReturnExpectedCoordinates()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "L1" };
            var path = new DayOne.Path(moves);

            // Act
            List<(int, int)> result = path.Build().ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal((-1, 0), result[0]);
        }

        [Fact]
        public void GivenARightWithOneUnitFollowedByALeftWithOneUnitDirectionShouldExpectedCoordinates()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R1", "L1" };
            var path = new DayOne.Path(moves);

            // Act
            List<(int, int)> result = path.Build().ToList();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            Assert.Equal((0, 0), result[1]);
        }
    }
}