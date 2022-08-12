using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YMonitorPointsDictionary
    {
        public int PrjId { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? MonitorType { get; set; }
        public double? Dist { get; set; }
        public double? X { get; set; }
        public int Identity { get; set; }
        public string? Remark { get; set; }
        public string? RingNumber { get; set; }
        public double? Mileage { get; set; }
        public string? Zone { get; set; }
        public int? BindingSubLine { get; set; }
        public int Id { get; set; }
    }
}
