using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MiniKompik16
{
    internal class Translator
    {
        private ushort GetOperationCode(string operation_name)
        {
            switch (operation_name)
            {
                case "nop":
                    return 0;
                case "mov":
                    return 1;
                case "or":
                    return 2;
                case "xor":
                    return 3;
                case "and":
                    return 4;
                case "rsh":
                    return 5;
                case "add":
                    return 6;
                case "sub":
                    return 7;
                case "lod":
                    return 8;
                case "str":
                    return 9;
                case "cal":
                    return 10;
                case "ret":
                    return 11;
                case "jmp":
                    return 12;
                case "brh":
                    return 13;
                case "ldi":
                    return 14;
                case "hlt":
                    return 15;
            }
            return 0;
        }
        public List<ushort> TranslateInstuctions(List<string> instructions_asm)
        {
            List<ushort> instructions_bin = new List<ushort>();

            for (int i = 0; i < instructions_asm.Count; i++)
            {
                instructions_bin.Add(0);
            }

            foreach (string instruction_asm in instructions_asm)
            {
                string str = instruction_asm;
                int pos = str.IndexOf(" ");
                ushort address = ushort.Parse(str.Substring(0, pos));

                str = str.Substring(pos + 1);
                pos = str.IndexOf(" ");
                string operation_name;

                if (pos == -1)
                {
                    operation_name = str.Substring(pos + 1);
                }
                else
                {
                    operation_name = str.Substring(0, pos);
                }

                ushort operation_code = GetOperationCode(operation_name);

                instructions_bin[address] |= (ushort)(operation_code << 12);

                if (operation_code == 1)
                {
                    str = str.Substring(pos + 1);
                    pos = str.IndexOf(" ");
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(0, pos)) << 4);

                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
                }
                if (operation_code >= 2 && operation_code <= 9)
                {
                    str = str.Substring(pos + 1);
                    pos = str.IndexOf(" ");
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(0, pos)) << 8);

                    str = str.Substring(pos + 1);
                    pos = str.IndexOf(" ");
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(0, pos)) << 4);

                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
                }
                if (operation_code == 10 || operation_code == 12)
                {
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
                }
                if (operation_code == 13)
                {
                    str = str.Substring(pos + 1);
                    pos = str.IndexOf(" ");
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(0, pos)) << 10);

                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
                }
                if (operation_code == 14)
                {
                    str = str.Substring(pos + 1);
                    pos = str.IndexOf(" ");
                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(0, pos)) << 4);

                    instructions_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
                }
            }
            return instructions_bin;
        }
        public List<ushort> TranslateData(List<string> data_asm)
        {
            List<ushort> data_bin = new List<ushort>();

            for (int i = 0; i < data_asm.Count; i++)
            {
                data_bin.Add(0);
            }

            foreach (string d in data_asm)
            {
                string str = d;
                int pos = str.IndexOf(" ");
                ushort address = ushort.Parse(str.Substring(0, pos));

                data_bin[address] |= (ushort)(ushort.Parse(str.Substring(pos + 1)) << 0);
            }
            return data_bin;
        }
    }
}
