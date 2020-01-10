namespace DayOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Distance
    {
        private IEnumerable<(int, int)> _firstMoves;
        private IEnumerable<(int, int)> _secondMoves;

        public Distance(IEnumerable<(int, int)> firstMoves, IEnumerable<(int, int)> secondMoves)
        {
            _firstMoves = firstMoves;
            _secondMoves = secondMoves;
        }

        public int GetDistanceFromNearestIntersection()
        {
            IEnumerable<(int, int)> intersections = _firstMoves.Intersect(_secondMoves);

            int distance = 0;

            foreach (var intersection in intersections)
            {
                int tempDistance = intersection.Item1 + intersection.Item2;
                if (distance == 0 || tempDistance < distance)
                {
                    distance = tempDistance;
                }
            }

            return distance;
        }
    }
}