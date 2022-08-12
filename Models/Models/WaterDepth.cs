using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class WaterDepth
    {
        public int Id { get; set; }
        public string? ParentType { get; set; }
        public string? Value { get; set; }
    }
}
