using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OldBuilding
    {
        public OldBuilding()
        {
            OldBuildingFileRecords = new HashSet<OldBuildingFileRecord>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Codenum { get; set; }
        public string? Address { get; set; }
        public string? ConYear { get; set; }
        public string? StructType { get; set; }
        public double? BaiduX { get; set; }
        public double? BaiduY { get; set; }
        public string? Details { get; set; }
        public double? Wgs84X { get; set; }
        public double? Wgs84Y { get; set; }

        public virtual ICollection<OldBuildingFileRecord> OldBuildingFileRecords { get; set; }
    }
}
