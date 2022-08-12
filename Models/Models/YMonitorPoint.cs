using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YMonitorPoint
    {
        public int PrjId { get; set; }
        public string? Name { get; set; }
        public double? Value { get; set; }
        public DateTime? DateTime { get; set; }
        public int Identity { get; set; }
        public string? Remark { get; set; }
        public int? No { get; set; }
    }
}
