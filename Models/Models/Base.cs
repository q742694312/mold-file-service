using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Base
    {
        public string ProjectName { get; set; } = null!;
        public string? ProjectNameing { get; set; }
        public string? ProjectAddress { get; set; }
        public string? Stage { get; set; }
        public string? Client { get; set; }
        public string? Desinger { get; set; }
        public string? ProjectManger { get; set; }
        public string? ProjectVerifid { get; set; }
        public string? ProjectApproved { get; set; }
        public string? TuManger { get; set; }
        public string? TuVerifid { get; set; }
        public string? TuApproved { get; set; }
        public int ProjectCount { get; set; }
        public short AgeNo { get; set; }
        public short? ProjectSubNb { get; set; }
        public string? ProjectSubname { get; set; }
        public double? WzX { get; set; }
        public double? WzY { get; set; }
        public string? Prospector { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84y { get; set; }
        public string? ProjectType { get; set; }
        public int Id { get; set; }
        public int? IsMetro { get; set; }
    }
}
