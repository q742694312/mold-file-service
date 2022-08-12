using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YProject
    {
        public int PrjId { get; set; }
        public string Name { get; set; } = null!;
        public int LineId { get; set; }
        public string? Location { get; set; }
        public string? Center { get; set; }
        public int Identity { get; set; }
        public int? Status { get; set; }
        public string? ProjectType { get; set; }
        public int? Sequence { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84y { get; set; }
        public string? IntervalName { get; set; }

        public virtual YProjectTypeEnum? ProjectTypeNavigation { get; set; }
    }
}
