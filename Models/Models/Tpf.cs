using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Tpf
    {
        public short Dep { get; set; }
        public short TpfsCount { get; set; }
        public short State { get; set; }
        public byte[]? QcFs { get; set; }
        public int Hnumber { get; set; }
        public int ProjectCount { get; set; }
        public bool? PsVarfg { get; set; }
    }
}
