using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayOne
{
    public class Intcode
    {
        private readonly string _intcode;
        private List<int[]> _opcodeInstructions;
        private int _lastValue = 0;

        private const int ADD_OPCODE = 1;
        private const int PROGRAM_END = 99;

        public Intcode(string intcode)
        {
            _intcode = intcode;

            BuildOpcodeInstructions();
        }

        private void BuildOpcodeInstructions()
        {
            var opcodes = _intcode.Split(',');

            _opcodeInstructions = new List<int[]>();

            var instructionsSet = new List<int>();

            foreach(var opcode in opcodes)
            {
                var numericOpcode = int.Parse(opcode);
                if (numericOpcode == PROGRAM_END)
                {
                    instructionsSet.Add(PROGRAM_END);
                    _opcodeInstructions.Add(instructionsSet.ToArray());
                }
            }
        }

        public int Compute()
        {
            int currentPointer = 0;
            int currentSetIndex = 0;

            int[] currentSet = _opcodeInstructions[currentSetIndex];

            while(currentSet.Length != 1 && currentSet.First() != PROGRAM_END)
            {
                if (currentSet[0] == ADD_OPCODE)
                {

                }
            }

            return _lastValue;
        }
    }
}