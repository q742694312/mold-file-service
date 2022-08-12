using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PPileInfo
    {
        public int Id { get; set; }
        public string? PileNo { get; set; }
        public string? PileType { get; set; }
        public double? WzX { get; set; }
        public double? WzY { get; set; }
        public DateTime? PileDate { get; set; }
        public DateTime? TestDate { get; set; }
        public string? PileShaftSize { get; set; }
        public string? PileTipSize { get; set; }
        public double? Lenth { get; set; }
        public string? Cno { get; set; }
        public string? PileConnect { get; set; }
        public string? Bearing { get; set; }
        public double? Maxtestload { get; set; }
        public double? DesighLoad { get; set; }
        public string? LimitLoad { get; set; }
        public double? Maxsettlement { get; set; }
        public double? Remsettlement { get; set; }
        public string? PileSoilType { get; set; }
        public int? ProjectId { get; set; }
        public int? PileId { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }
        public string? Projectname { get; set; }
    }
}
