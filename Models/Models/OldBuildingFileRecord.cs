using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class OldBuildingFileRecord
    {
        public int Id { get; set; }
        public string? FileType { get; set; }
        public string? FilePath { get; set; }
        public string? FileAutoName { get; set; }
        public string? FileOriginalName { get; set; }
        public int? FileSize { get; set; }
        public DateTime? FileUploadTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public int BuildingId { get; set; }

        public virtual OldBuilding Building { get; set; } = null!;
    }
}
