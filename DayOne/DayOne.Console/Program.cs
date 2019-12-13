namespace DayOne.Console
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"moduleList.txt");

            decimal sum = lines.Sum(l => Calculator.GetFuel(int.Parse(l)));

            Console.WriteLine($"Module sum: {sum}");

            lines = System.IO.File.ReadAllLines(@"intcode.txt");

            int[] intcodes = lines.First().Split(',').Select(c => int.Parse(c)).ToArray();
            intcodes[1] = 12;
            intcodes[2] = 2;

            var intcode = new Intcode(intcodes);

            Console.WriteLine($"Intcode: {intcode.Compute()}");

            for (var i = 0; i <= 99; i++)
            {
                for (var j = 0; j <= 99; j++)
                {
                    intcode.Reset();
                    intcodes[1] = i;
                    intcodes[2] = j;

                    int output = intcode.Compute();
                    if (output == 19690720)
                    {
                        int nounVerb = 100 * i + j;
                        Console.WriteLine($"Noun + Verb: {nounVerb}");
                        break;
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
