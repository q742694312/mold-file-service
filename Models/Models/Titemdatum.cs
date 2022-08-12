using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Titemdatum
    {
        public int? ProjectCount { get; set; }
        public float? Imin { get; set; }
        public float? Imax { get; set; }
        public float? Iavg { get; set; }
        public float? Ivar { get; set; }
        public float? Icv { get; set; }
        public int? IN { get; set; }
        public int? N { get; set; }
        public short? AgeNo { get; set; }
        public string? ItemCode { get; set; }
        public int Tid { get; set; }
        public string? ExTitle { get; set; }
        public short? Itemtype { get; set; }
        public short? ISort { get; set; }
        public int Anumber { get; set; }
    }
}
