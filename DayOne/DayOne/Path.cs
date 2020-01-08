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
            int currentX = 0;
            int currentY = 0;

            foreach(string move in _moves)
            {
                string length = move.Substring(1, move.Length - 1);
                for (int i = 0; i < int.Parse(length); i++)
                {
                    currentX += 1;
                    path.Add((currentX, currentY));
                }
            }

            return path;
        }
    }
}