using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Affusion
    {
        public int Hnumber { get; set; }
        public int Anumber { get; set; }
        public float Sdep { get; set; }
        public float Edep { get; set; }
        public float Caput { get; set; }
        public float Water { get; set; }
        public float Bush { get; set; }
        public float TestL { get; set; }
        public bool BUse { get; set; }
        public DateTime Fate { get; set; }
        public DateTime BTime { get; set; }
        public DateTime ETime { get; set; }
        public short Dcount { get; set; }
        public byte[]? Data { get; set; }
        public int ProjectCount { get; set; }
        public short TNo { get; set; }
        public float M { get; set; }
        public int Tid { get; set; }
    }
}
