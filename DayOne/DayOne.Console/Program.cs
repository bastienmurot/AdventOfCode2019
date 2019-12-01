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

            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
