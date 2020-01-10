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
                string direction = move.Substring(0, 1);
                string length = move.Substring(1, move.Length - 1);
                for (int i = 0; i < int.Parse(length); i++)
                {

                    switch (direction)
                    {
                        case "R":
                            currentX += 1;
                            break;
                        case "L":
                            if (i > 0 && currentX == 1) break;
                            currentX -= 1;
                            break;
                        case "U":
                            currentY += 1;
                            break;
                        case "D":
                            if (i > 0 && currentY == 1) break;
                            currentY -= 1;
                            break;
                    }
                    
                    path.Add((currentX, currentY));
                }
            }

            return path;
        }
    }
}