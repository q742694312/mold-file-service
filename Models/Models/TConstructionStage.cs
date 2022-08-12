using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TConstructionStage
    {
        public long Id { get; set; }
        public int? ConstructionStageSerialNum { get; set; }
        public string? ConstructionStageName { get; set; }
        public string? Detail { get; set; }
        public DateTime? ConstructionStartDate { get; set; }
        public DateTime? ConstructionEndDate { get; set; }
        public long? ProProgressId { get; set; }
        public long? Pid { get; set; }
        public string? Memo { get; set; }
        public string? ConstructionStageId { get; set; }

        public virtual TProjectProgress? ProProgress { get; set; }
    }
}
