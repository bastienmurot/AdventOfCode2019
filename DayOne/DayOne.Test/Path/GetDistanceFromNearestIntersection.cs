namespace DayOne.Test.Path
{
    using System.Collections.Generic;
    using Xunit;

    public class GetDistanceFromNearestIntersection
    {
        [Fact]
        public void ItExists()
        {
            // Arrange
            var pathOneMoves = new List<string> { "R8", "U5", "L5" };
            var pathTwoMoves = new List<string> { "U7", "R6", "D4" };

            var pathOne = new DayOne.Path(pathOneMoves);
            var pathTwo = new DayOne.Path(pathTwoMoves);
            
            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            // Act & Assert
            int result = distance.GetDistanceFromNearestIntersection();
        }

        [Fact]
        public void GivenOneIntersectionShouldReturnDistance()
        {
            // Arrange
            var pathOneMoves = new List<string> { "R8", "U5", "L5" };
            var pathTwoMoves = new List<string> { "U7", "R6", "D4" };

            var pathOne = new DayOne.Path(pathOneMoves);
            var pathTwo = new DayOne.Path(pathTwoMoves);

            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            // Act
            int result = distance.GetDistanceFromNearestIntersection();

            // Assert
            Assert.Equal(11, result);
        }

        [Fact]
        public void GivenTwoIntersectionsShouldReturnDistance()
        {
            // Arrange
            var pathOneMoves = new List<string> { "R8", "U5", "L5", "D3" };
            var pathTwoMoves = new List<string> { "U7", "R6", "D4", "L4" };

            var pathOne = new DayOne.Path(pathOneMoves);
            var pathTwo = new DayOne.Path(pathTwoMoves);

            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            // Act
            int result = distance.GetDistanceFromNearestIntersection();

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void GivenMultipleIntersectionsShouldReturnDistance()
        {
            // Arrange
            var pathOneMoves = new List<string> { "R75", "D30", "R83", "U83", "L12" , "D49", "R71", "U7", "L72" };
            var pathTwoMoves = new List<string> { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };

            var pathOne = new DayOne.Path(pathOneMoves);
            var pathTwo = new DayOne.Path(pathTwoMoves);

            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            // Act
            int result = distance.GetDistanceFromNearestIntersection();

            // Assert
            Assert.Equal(159, result);
        }

        [Fact]
        public void GivenOtherMultipleIntersectionsShouldReturnDistance()
        {
            // Arrange
            var pathOneMoves = new List<string> { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" };
            var pathTwoMoves = new List<string> { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" };

            var pathOne = new DayOne.Path(pathOneMoves);
            var pathTwo = new DayOne.Path(pathTwoMoves);

            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            // Act
            int result = distance.GetDistanceFromNearestIntersection();

            // Assert
            Assert.Equal(135, result);
        }
    }
}