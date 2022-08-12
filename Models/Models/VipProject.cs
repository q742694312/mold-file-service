using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VipProject
    {
        public int Id { get; set; }
        public string? ProjectName { get; set; }
        public string? Adress { get; set; }
        public int? Belong { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }
        public string? Bimmodel { get; set; }
        public int? Pid { get; set; }
        public string? ProjectType { get; set; }
        public string? Region { get; set; }
        public int? IsLinable { get; set; }
        public DateTime? LatestTime { get; set; }
        public string? LatestUser { get; set; }
        public bool Isdelete { get; set; }
        public string? State { get; set; }
        public bool? IsCase { get; set; }
        public string? GeoGis { get; set; }
    }
}
