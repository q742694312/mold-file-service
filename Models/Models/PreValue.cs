using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PreValue
    {
        public int Id { get; set; }
        public string? PointId { get; set; }
        public byte[]? Gongkuang { get; set; }
        public int? Gksequence { get; set; }
        public double? PreValue1 { get; set; }
        public double? ReaValue { get; set; }
        public int? IsMax { get; set; }
        public int? ProjectId { get; set; }
    }
}
