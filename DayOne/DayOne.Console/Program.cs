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

            Intcode intcode = new Intcode(lines.First());

            Console.WriteLine($"Intcode: {intcode.Compute()}");

            Console.ReadLine();
        }
    }
}
