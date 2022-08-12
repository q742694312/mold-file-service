using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Pmhole
    {
        public int Pnumber { get; set; }
        public int Hnumber { get; set; }
        public float Distance { get; set; }
        public float? Excursion { get; set; }
        public short N { get; set; }
        public int ProjectCount { get; set; }
        public int Tid { get; set; }
        public bool CutFg { get; set; }
    }
}
