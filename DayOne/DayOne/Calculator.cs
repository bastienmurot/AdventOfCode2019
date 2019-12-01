using System;

namespace DayOne
{
    public class Calculator
    {
        public static int GetFuel(int mass)
        {
            return Math.Abs(mass / 3) - 2;
        }
    }
}
