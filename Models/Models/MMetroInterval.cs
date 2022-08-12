using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MMetroInterval
    {
        public int MetroIntervalId { get; set; }
        public int MetroSectionId { get; set; }
        public string? MetroIntervalName { get; set; }
        public int? IntervalHoopWide { get; set; }
        public int? IntervalHoopCount { get; set; }
        public int? IntervalType { get; set; }
        public int? IntervalDirect { get; set; }
        public int? IntervalSequence { get; set; }
        public int? IntervalShaftCount { get; set; }
        public string? IntervalRemark { get; set; }
        public int? IntervalIsDel { get; set; }
        public string? IntervalDelTime { get; set; }
        public string? GeoZone { get; set; }
        public string? AcrossSoillayer { get; set; }
    }
}
