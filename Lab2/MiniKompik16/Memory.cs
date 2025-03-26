using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKompik16
{
    internal class Memory
    {
        public List<ushort> Data { get; set; }
        public List<ushort> Instructions { get; set; }
        public Memory() 
        {
            Data = new List<ushort>();
            Instructions = new List<ushort>();
        }
    }
}
