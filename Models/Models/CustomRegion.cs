using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class CustomRegion
    {
        public int CustomRegionId { get; set; }
        public string? RegionName { get; set; }
        public string? Coordinates { get; set; }
        public string? Bimmodelid { get; set; }
        public int? Cim { get; set; }
        public int? ParentId { get; set; }
        public string? Title { get; set; }
        public string? Type { get; set; }
        public string? City { get; set; }
        public DateTime? LatestTime { get; set; }
        public string? LatestUser { get; set; }
        public bool Isdelete { get; set; }
    }
}
