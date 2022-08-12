using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Pmtadjust
    {
        public int? MSize { get; set; }
        public byte[]? MData { get; set; }
        public int Pnumber { get; set; }
        public int ProjectCount { get; set; }
        public short Subnumber { get; set; }
        public int Tid { get; set; }
    }
}
