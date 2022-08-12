using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PPileTest
    {
        public int Id { get; set; }
        public int? PileId { get; set; }
        public int? SequencNo { get; set; }
        public double? Load { get; set; }
        public int? Duration { get; set; }
        public int? TotalDuration { get; set; }
        public double? Settlement { get; set; }
        public double? TotalSettlement { get; set; }
    }
}
