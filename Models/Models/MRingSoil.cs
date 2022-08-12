using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MRingSoil
    {
        public int Id { get; set; }
        public int? RingNum { get; set; }
        public int? IntervalId { get; set; }
        public string? ThroughsoilNo { get; set; }
        public string? ThroughsoilName { get; set; }
        public string? TopsoilNo { get; set; }
        public double? TopsoilLength { get; set; }
        public string? BottomsoilNo { get; set; }
        public double? BottomsoilLength { get; set; }
        public double? RingTopdepth { get; set; }
        public double? RingBottomdepth { get; set; }
        public double? RingTopheight { get; set; }
        public double? RingMiddleheight { get; set; }
        public double? RingBottomheight { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string? Direct { get; set; }
        public string? Guid { get; set; }
        public string? Pid { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }
    }
}
