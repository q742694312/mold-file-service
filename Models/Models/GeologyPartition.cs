using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class GeologyPartition
    {
        public int Objectid { get; set; }
        public string? Thickness { get; set; }
        public string? GeologyType { get; set; }
        public string? Remark { get; set; }
        public string? Belong { get; set; }
    }
}
