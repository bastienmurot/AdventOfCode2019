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
    }
}