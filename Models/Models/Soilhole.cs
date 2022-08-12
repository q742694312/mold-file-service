using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Soilhole
    {
        public string SoilHoleNo { get; set; } = null!;
        public short HoleOrder { get; set; }
        public int SoilHnumber { get; set; }
        public int? Hnumber { get; set; }
        public int ProjectCount { get; set; }
        public short AgeNo { get; set; }
    }
}
