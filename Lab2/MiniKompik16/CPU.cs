using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKompik16
{
    internal class CPU
    {
        public bool IsRunning;

        private ushort Instruction;

        private ushort OperationCode;
        private ushort RegisterA;
        private ushort RegisterB;
        private ushort RegisterC;

        private ushort Condition;
        private ushort Address;
        private ushort Offset;
        private ushort Immediate;

        public List<ushort> Registrs;
        public ushort ProgramCounter;
        private bool FlagLessZero;
        private bool FlagIsZero;
        private Stack<ushort> CallStack;
        
        public CPU() 
        {
            IsRunning = false;

            Instruction = 0;

            OperationCode = 0;
            RegisterA = 0;
            RegisterB = 0;
            RegisterC = 0;

            Condition = 0;
            Address = 0;
            Offset = 0;
            Immediate = 0;

            Registrs = new List<ushort>() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            ProgramCounter = 0;
            FlagLessZero = false;
            FlagIsZero = false;
            CallStack = new Stack<ushort>();
        }

        private void ReadInstruction(Memory memory)
        {
            Instruction = memory.Instructions[ProgramCounter];
        }

        private void Count()
        {
            ProgramCounter += 1;
        }

        private void DecodingInstruction() 
        {
            OperationCode = (ushort)(Instruction >> 12);

            RegisterA = (ushort)((Instruction >> 8) & 15);
            RegisterB = (ushort)((Instruction >> 4) & 15);
            RegisterC = (ushort)((Instruction >> 0) & 15);

            Condition = (ushort)((Instruction >> 10) & 3);
            Address = (ushort)((Instruction >> 0) & 1023);
            Offset = (ushort)((Instruction >> 4) & 15);
            Immediate = (ushort)((Instruction >> 4) & 255);
        }

        private void SetFlag(short res)
        {
            if (res == 0)
            {
                FlagIsZero = true;
            }
            if (res != 0)
            {
                FlagIsZero = false;
            }
            if (res < 0)
            {
                FlagLessZero = true;
            }
            if (res >= 0)
            {
                FlagLessZero = false;
            }
        }

        private void ExecuteInstruction(Memory memory)
        {
            if (OperationCode == 0)
            {
                return;
            }
            if (OperationCode == 1) 
            {
                Registrs[RegisterC] = Registrs[RegisterB];
            }
            if (OperationCode == 2)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] | Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 3)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] ^ Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 4)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] & Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 5)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] >> Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 6)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] + Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 7)
            {
                Registrs[RegisterC] = (ushort)(Registrs[RegisterA] - Registrs[RegisterB]);
                SetFlag((short)Registrs[RegisterC]);
            }
            if (OperationCode == 8)
            {
                Registrs[RegisterC] = memory.Data[RegisterA + Offset];
            }
            if (OperationCode == 9)
            {
                memory.Data[RegisterA + Offset] = Registrs[RegisterC];
            }
            if (OperationCode == 10)
            {
                CallStack.Push(ProgramCounter);
                ProgramCounter = Address;
            }
            if (OperationCode == 11)
            {
                ProgramCounter = CallStack.Pop();
            }
            if (OperationCode == 12)
            {
                ProgramCounter = Address;
            }
            if (OperationCode == 13)
            {
                if (Condition == 0 && FlagIsZero == true) ProgramCounter = Address;
                if (Condition == 1 && FlagIsZero == false) ProgramCounter = Address;
                if (Condition == 2 && FlagLessZero == true) ProgramCounter = Address;
                if (Condition == 3 && FlagIsZero == false) ProgramCounter = Address;
            }
            if (OperationCode == 14)
            {
                Registrs[RegisterC] = Immediate;
            }
            if (OperationCode == 15)
            {
                IsRunning = false;
            }
        }

        public void Tick(Memory memory)
        {
            ReadInstruction(memory);
            Count();
            DecodingInstruction();
            ExecuteInstruction(memory);
        }

        public void Reset()
        {
            IsRunning = false;

            Instruction = 0;

            OperationCode = 0;
            RegisterA = 0;
            RegisterB = 0;
            RegisterC = 0;

            Condition = 0;
            Address = 0;
            Offset = 0;
            Immediate = 0;

            Registrs = new List<ushort>() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; ;
            ProgramCounter = 0;
            FlagLessZero = false;
            FlagIsZero = false;
            CallStack = new Stack<ushort>();
        }
    }
}
