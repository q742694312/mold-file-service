using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TApplicationDatum
    {
        public short? ApplicationId { get; set; }
        public short? FormId { get; set; }
        public int? Totalsize { get; set; }
        public int? Item1size { get; set; }
        public int? Item2size { get; set; }
        public int? Item3size { get; set; }
        public byte[]? Bindata { get; set; }
        public int? Hnumber { get; set; }
        public int? ProjectCount { get; set; }
        public short? AgeNo { get; set; }
        public int Tid { get; set; }
        public int? Pnumber { get; set; }
        public int? Mnumber { get; set; }
    }
}
