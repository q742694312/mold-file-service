using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TProject
    {
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Code { get; set; }
        public string? Address { get; set; }
        public string? Name { get; set; }
        public string? ProLevel { get; set; }
        public string? ProType { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }
        public string? PrjState { get; set; }
        public string? ProStageState { get; set; }
        public decimal? ExcavateDepth { get; set; }
        public DateTime? ExpectStartDate { get; set; }
        public DateTime? ExpectEndDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string? SurroundType { get; set; }
        public decimal? SurroundDepth { get; set; }
        public string? Manager { get; set; }
        public long Id { get; set; }
        public string? AbbreviationName { get; set; }
        public string? Pid { get; set; }
        public string? GeoZone { get; set; }
        public decimal? ShortestDistanceToTunnel { get; set; }
        public decimal? BiggestDepthofTunnel { get; set; }
        public string? ProjectType { get; set; }
        public decimal? ExcavateArea { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84y { get; set; }
        public string? Procom { get; set; }
    }
}
