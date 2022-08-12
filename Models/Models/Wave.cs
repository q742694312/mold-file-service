using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Wave
    {
        public int ProjectCount { get; set; }
        public short AgeNo { get; set; }
        public int Hnumber { get; set; }
        public short TestWay { get; set; }
        public float? D0 { get; set; }
        public string? Tno { get; set; }
        public float? Dspace { get; set; }
        public float? Defernce { get; set; }
        public DateTime? Cdate { get; set; }
        public float? T { get; set; }
        public float? M { get; set; }
        public int Totalsize { get; set; }
        public byte[] Data1 { get; set; } = null!;
        public int Tid { get; set; }
    }
}
