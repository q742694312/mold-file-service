using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PileInfo
    {
        public int PileId { get; set; }
        public int Projectid { get; set; }
        public string PileNo { get; set; } = null!;
        public string? PileType { get; set; }
        public double? TopHeight { get; set; }
        public double? PileDepth { get; set; }
        public double? PileDiameter { get; set; }
        public string? PileLocation { get; set; }
        public double? DesignLoading { get; set; }
        public double? ProposedLoading { get; set; }
        public double? MaxDeformation { get; set; }
        public double? MaxSpringback { get; set; }
        public double? SpringbackRate { get; set; }
        public DateTime? PilesinkingDate { get; set; }
        public DateTime? TestDate { get; set; }
        public string? Conclusion { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeleteTime { get; set; }
        public int? DeleteId { get; set; }
        public int? UpdateId { get; set; }

        public virtual PileProject Project { get; set; } = null!;
    }
}
