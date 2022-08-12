using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Consolid
    {
        public short Series { get; set; }
        public float? ModifyG { get; set; }
        public float? ModifyD { get; set; }
        public bool? Isuse { get; set; }
        public float? ModifyEi { get; set; }
        public float? ModifyPi { get; set; }
        public byte[]? Consolid1 { get; set; }
        public float? MaxP { get; set; }
        public short Method { get; set; }
        public int ProjectCount { get; set; }
        public int Tnumber { get; set; }
    }
}
