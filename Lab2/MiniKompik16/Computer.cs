using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MiniKompik16
{
    internal class Computer
    {
        private Translator Translator;
        private Memory Memory;
        private CPU CPU;

        public Computer(Translator translator, Memory memory, CPU cpu)
        {
            Translator = translator;
            Memory = memory;
            CPU = cpu;
        }

        public void RunProrgam(List<string> program, List<string> data)
        {
            Memory.Instructions = Translator.TranslateInstuctions(program);
            Memory.Data = Translator.TranslateData(data);
            CPU.Tick(Memory);
        }

        public void Restart()
        {
            Memory.Instructions.Clear();
            Memory.Data.Clear();
            CPU.Reset();
        }

        public ushort GetRegisterValue(int reg)
        {
            return CPU.Registrs[reg];
        }

        public ushort GetCurrentLine()
        {
            return CPU.ProgramCounter;
        }
    }
}
