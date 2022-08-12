using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class DmtDatum
    {
        public float? WaterLevel { get; set; }
        public float? StartDep { get; set; }
        public int? DataCount { get; set; }
        public float? Da { get; set; }
        public float? Db { get; set; }
        public float? Zm { get; set; }
        public string? EquipNo { get; set; }
        public byte[]? BData { get; set; }
        public int Hnumber { get; set; }
        public int ProjectCount { get; set; }
    }
}
