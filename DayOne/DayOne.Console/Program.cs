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

            Intcode intcode = new Intcode(intcodes);

            Console.WriteLine($"Intcode: {intcode.Compute()}");

            Console.ReadLine();
        }
    }
}
