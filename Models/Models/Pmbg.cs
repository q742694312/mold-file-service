using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Pmbg
    {
        public int Hnumber { get; set; }
        public string? Bgpoint { get; set; }
        public float? Startpos { get; set; }
        public float? Endpos { get; set; }
        public float? N635 { get; set; }
        public int ProjectCount { get; set; }
        public short AgeNo { get; set; }
        public int Tid { get; set; }
        public byte? StatFg { get; set; }
    }
}
