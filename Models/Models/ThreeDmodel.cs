using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ThreeDmodel
    {
        public int Id { get; set; }
        public int? LineId { get; set; }
        public string? IntervalName { get; set; }
        public string? ModelId { get; set; }
        public int? Pid { get; set; }
        public int? Int { get; set; }
    }
}
