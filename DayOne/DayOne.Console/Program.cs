namespace DayOne.Console
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = ComputeModuleSum();

            Console.WriteLine($"Module sum: {sum}");
            
            Intcode intcode = ComputeIntCode();

            Console.WriteLine($"Intcode: {intcode.Compute()}");

            for (var i = 0; i <= 99; i++)
            {
                for (var j = 0; j <= 99; j++)
                {
                    intcode.Reset();
                    intcode.Intcodes[1] = i;
                    intcode.Intcodes[2] = j;

                    int output = intcode.Compute();
                    if (output == 19690720)
                    {
                        int nounVerb = 100 * i + j;
                        Console.WriteLine($"Noun + Verb: {nounVerb}");
                        break;
                    }
                }
            }

            int closestIntersection = ComputeClosestIntersection();

            Console.WriteLine($"Closest intersection: {closestIntersection}");

            Console.ReadLine();
        }

        private static Intcode ComputeIntCode()
        {
            string[] lines = System.IO.File.ReadAllLines(@"intcode.txt");

            int[] intcodes = lines.First().Split(',').Select(c => int.Parse(c)).ToArray();
            intcodes[1] = 12;
            intcodes[2] = 2;

            return new Intcode(intcodes);
        }

        private static decimal ComputeModuleSum()
        {
            string[] lines = System.IO.File.ReadAllLines(@"moduleList.txt");

            return lines.Sum(l => Calculator.GetFuel(int.Parse(l)));
        }

        private static int ComputeClosestIntersection()
        {
            string[] lines = System.IO.File.ReadAllLines(@"crossedwires.txt");

            var pathOne = new Path(lines[0].Split(','));
            var pathTwo = new Path(lines[1].Split(','));

            var distance = new Distance(pathOne.Build(), pathTwo.Build());

            return distance.GetDistanceFromNearestIntersection();
        }
    }
}
