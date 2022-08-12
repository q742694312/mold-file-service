using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PBuildingInfo
    {
        public int Id { get; set; }
        public string ProjectNo { get; set; } = null!;
        public string? BuildingName { get; set; }
        public string? BuildingNo { get; set; }
        public string? StructType { get; set; }
        public int? FloorNo { get; set; }
        public double? BuildingArea { get; set; }
        public DateTime? Start { get; set; }
        public double? Eqlength { get; set; }
        public double? Eqwidth { get; set; }
        public double? FoundationDepth { get; set; }
        public double? Pilelenth { get; set; }
        public double? AbsTopHeight { get; set; }
        public double? AbsBottomHeight { get; set; }
        public int? Totalpile { get; set; }
        public int? ProjectId { get; set; }
        public string? ProjectName { get; set; }
    }
}
