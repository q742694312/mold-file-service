using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class BlockTypeNum
    {
        public int Id { get; set; }
        public string? BlockType { get; set; }
        public string? BlockTypeName { get; set; }
        public string? BlockRgb { get; set; }
        public string? Notes { get; set; }
    }
}
