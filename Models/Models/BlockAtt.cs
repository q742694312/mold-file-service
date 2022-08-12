using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class BlockAtt
    {
        public int Id { get; set; }
        public string? BlockId { get; set; }
        public double? BlockArea { get; set; }
        public string? BlockType { get; set; }
        public double? BuildingHeight { get; set; }
        public string? PlanTarget { get; set; }
        public string? BlockAtt1 { get; set; }
        public string? BlockBelong { get; set; }
        public string? BuildingInfo { get; set; }
        public int? UnderGround { get; set; }
    }
}
