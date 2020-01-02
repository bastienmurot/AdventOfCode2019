namespace DayOne.Test
{
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class GetClosestIntersection
    {
        [Fact]
        public void ItExists()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R8", "U5", "L5", "D3" };
            var path = new Path(moves);

            // Act & Assert
            IEnumerable<(int, int)> points = path.Build();
        }

        [Fact]
        public void GivenARightWithOneUnitDirectionShouldReturnOneElementInList()
        {
            // Arrange
            IEnumerable<string> moves = new List<string> { "R1"};
            var path = new Path(moves);

            // Act
            IEnumerable<(int, int)> result = path.Build();

            // Assert
            Assert.NotNull(result);
            Assert.Equal((0, 1), result.First());
        }
    }
}