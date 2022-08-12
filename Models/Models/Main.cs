using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Main
    {
        public string SoilNo { get; set; } = null!;
        public float? Stardep { get; set; }
        public float? Enddep { get; set; }
        public string? Color { get; set; }
        public short AgeNo { get; set; }
        public DateTime CreateDate { get; set; }
        public int ProjectCount { get; set; }
        public int Tnumber { get; set; }
        public int SoilHnumber { get; set; }
        public string? CnNote { get; set; }
    }
}
