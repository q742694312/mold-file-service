using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Pholeatt
    {
        public int ProjectCount { get; set; }
        public string Holeno { get; set; } = null!;
        public float? Height { get; set; }
        public float? Depth { get; set; }
        public float? Waterlevel { get; set; }
        public short Attribute { get; set; }
        public int Hnumber { get; set; }
        public short AgeNo { get; set; }
        public byte? Zklx { get; set; }
        public double? WzX { get; set; }
        public double? WzY { get; set; }
        public short? HoleOrder { get; set; }
        public float? SlurryStar { get; set; }
        public float? SlurryEnd { get; set; }
        public bool? IsTran { get; set; }
        public short? ProjectSource { get; set; }
        public double? TzX { get; set; }
        public double? TzY { get; set; }
        public float? TzOffset { get; set; }
        public string? Lastlayerno { get; set; }
        public string? Assort { get; set; }
        public int? AssortNb { get; set; }
        public double? WzWgs84x { get; set; }
        public double? WzWgs84y { get; set; }
        public double? TzWgs84x { get; set; }
        public double? TzWgs84y { get; set; }
        public string? City { get; set; }
    }
}
