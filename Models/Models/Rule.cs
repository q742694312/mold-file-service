using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Rule
    {
        public float? W { get; set; }
        public float? P0 { get; set; }
        public float? H { get; set; }
        public float? Wl { get; set; }
        public float? Wp { get; set; }
        public float? C { get; set; }
        public float? Q { get; set; }
        public float? A0102 { get; set; }
        public float? Es0102 { get; set; }
        public float? Kv { get; set; }
        public float? Kh { get; set; }
        public short? Note { get; set; }
        public byte? CqFlag { get; set; }
        public int ProjectCount { get; set; }
        public int Tnumber { get; set; }
    }
}
