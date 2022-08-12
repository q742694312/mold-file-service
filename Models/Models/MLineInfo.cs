using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MLineInfo
    {
        public int MetroId { get; set; }
        public string? MetroName { get; set; }
        public int? MetroCode { get; set; }
        public double? MetroLength { get; set; }
        public DateTime MetroOpenTime { get; set; }
        public TimeSpan? MetroUpStartTime { get; set; }
        public TimeSpan? MetroUpEndTime { get; set; }
        public TimeSpan? MetroDownStartTime { get; set; }
        public TimeSpan? MetroDownEndTime { get; set; }
        public string? MetroStartStationId { get; set; }
        public string? MetroEndStationId { get; set; }
        public int? CityId { get; set; }
        public string? MetroColor { get; set; }
        public string? MetroRemark { get; set; }
        public int? MetroIsDel { get; set; }
        public string? MetroDelTime { get; set; }
    }
}
