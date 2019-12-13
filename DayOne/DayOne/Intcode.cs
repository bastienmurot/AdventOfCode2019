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

        public int Compute()
        {
            int currentIndex = 0;
            int lastValue = 0;

            while (_intcodes[currentIndex] != PROGRAM_END)
            {
                if (_intcodes[currentIndex] == ADD_OPCODE)
                {
                    lastValue = _intcodes[_intcodes[currentIndex + 1]] + _intcodes[_intcodes[currentIndex + 2]];
                    _intcodes[_intcodes[currentIndex + 3]] = lastValue;
                }
                if (_intcodes[currentIndex] == MULTIPLY_OPCODE)
                {
                    lastValue = _intcodes[_intcodes[currentIndex + 1]] * _intcodes[_intcodes[currentIndex + 2]];
                    _intcodes[_intcodes[currentIndex + 3]] = lastValue;
                }

                currentIndex += 4;
            }

            return lastValue;
        }

        public void Reset()
        {
            Array.Copy(_originalIntCode, _intcodes, _originalIntCode.Length);
        }
    }
}