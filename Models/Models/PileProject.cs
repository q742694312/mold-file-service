using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PileProject
    {
        public PileProject()
        {
            PileInfos = new HashSet<PileInfo>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public string? ProjectAddress { get; set; }
        public string? ConstructionUnit { get; set; }
        public string? ClientUnit { get; set; }
        public string? DesignerUnit { get; set; }
        public string? SupervisorUnit { get; set; }
        public string? WorkingUnit { get; set; }
        public string? TestUnit { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public string? Description { get; set; }
        public double? Wgs84x { get; set; }
        public double? Wgs84y { get; set; }
        public int? DeleteId { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool? IsDelete { get; set; }
        public int? UpdateId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? ProjectNo { get; set; }

        public virtual ICollection<PileInfo> PileInfos { get; set; }
    }
}
