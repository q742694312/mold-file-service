using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YMonitorProjectExtraInfo
    {
        public int PrjId { get; set; }
        public string? PrjLevel { get; set; }
        public string? PrjSummary { get; set; }
        public string? TunnelType { get; set; }
        public int Identity { get; set; }
        public string? PrjState { get; set; }
        public string? ConstructionCorp { get; set; }
        public string? Department { get; set; }
        public string? OwnerCorp { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? ContractStartTime { get; set; }
        public DateTime? ContractEndTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Frequency { get; set; }
        public decimal? ExcavateDepth { get; set; }
        public decimal? ExcavateArea { get; set; }
        public string? Address { get; set; }
        public decimal? ShortestDistanceToTunnel { get; set; }
        public decimal? BiggestDepthOfTunnel { get; set; }
        public string? GeoZone { get; set; }
    }
}
