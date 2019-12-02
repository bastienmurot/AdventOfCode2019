using System;

namespace DayOne
{
    public class Calculator
    {
        public static int GetFuel(int mass)
        {
            int fuel = ComputeNeededFuel(mass);

            int result = fuel;

            while (fuel > 0)
            {
                fuel = ComputeNeededFuel(fuel);

                if (fuel > 0)
                {
                    result += fuel;
                }
            }

            return result;
        }

        private static int ComputeNeededFuel(int mass)
        {
            return Math.Abs(mass / 3) - 2;
        }

        public static int RecurseGetFuel(int mass)
        {
            int result = 0;

            while (mass > 0)
            {
                result = ComputeNeededFuel(mass);

                mass = result;

                if (result > 0)
                {
                    result += RecurseGetFuel(result);
                }
            }

            return result;
        }
    }
}
