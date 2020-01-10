using System;

namespace DayOne
{
    public class Intcode
    {
        private readonly int[] _intcodes;
        private int[] _originalIntCode;

        private const int ADD_OPCODE = 1;
        private const int MULTIPLY_OPCODE = 2;
        private const int PROGRAM_END = 99;

        public Intcode(int[] intcode)
        {
            _intcodes = intcode;
            _originalIntCode = new int[intcode.Length];
            Array.Copy(intcode, _originalIntCode, intcode.Length);
        }

        public int[] Intcodes => _intcodes;

        public int Compute()
        {
            int currentIndex = 0;
            int lastValue = 0;

            while (Intcodes[currentIndex] != PROGRAM_END)
            {
                if (Intcodes[currentIndex] == ADD_OPCODE)
                {
                    lastValue = Intcodes[Intcodes[currentIndex + 1]] + Intcodes[Intcodes[currentIndex + 2]];
                    Intcodes[Intcodes[currentIndex + 3]] = lastValue;
                }
                if (Intcodes[currentIndex] == MULTIPLY_OPCODE)
                {
                    lastValue = Intcodes[Intcodes[currentIndex + 1]] * Intcodes[Intcodes[currentIndex + 2]];
                    Intcodes[Intcodes[currentIndex + 3]] = lastValue;
                }

                currentIndex += 4;
            }

            return lastValue;
        }

        public void Reset()
        {
            Array.Copy(_originalIntCode, Intcodes, _originalIntCode.Length);
        }
    }
}