namespace DayOne
{
    using System.Collections.Generic;
    using System.Linq;

    public class Path
    {
        private readonly List<string> _moves;

        public Path(IEnumerable<string> moves)
        {
            _moves = moves.ToList();
        }

        public IEnumerable<(int, int)> Build()
        {
            List<(int, int)> path = new List<(int, int)>();

            path.Add((0, 1));

            return path;
        }
    }
}