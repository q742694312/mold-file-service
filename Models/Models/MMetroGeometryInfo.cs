using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MMetroGeometryInfo
    {
        public int MetroGeoLineId { get; set; }
        public int MetroIntervalId { get; set; }
        public string? SegmentLiningsId { get; set; }
        public int? GeoLineStructureType { get; set; }
        public double? GeoLineX { get; set; }
        public double? GeoLineY { get; set; }
        public double? GeoLineBaiDuX { get; set; }
        public double? GeoLineBaiDuY { get; set; }
        public double? GeoLineWgs84x { get; set; }
        public double? GeoLineWgs84y { get; set; }
        public double? GeoLineEvaluation { get; set; }
        public int? GeoLineDirect { get; set; }
        public int? GeoLinePointSequence { get; set; }
        public double? GeoLineMileage { get; set; }
        public int? GeoLineCalcFlag { get; set; }
        public string? GeoLineRemark { get; set; }
        public int? GeoLineIsDel { get; set; }
        public string? GeoLineDelTime { get; set; }
    }
}
