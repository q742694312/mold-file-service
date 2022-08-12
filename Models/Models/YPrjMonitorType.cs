using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YPrjMonitorType
    {
        public int PrjId { get; set; }
        public string MonitorType { get; set; } = null!;
        public int Identity { get; set; }
        public string? Remark { get; set; }
    }
}
