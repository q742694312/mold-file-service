using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TProjectProgress
    {
        public TProjectProgress()
        {
            TConstructionStages = new HashSet<TConstructionStage>();
        }

        public int? ProgressSerialNum { get; set; }
        public string? Name { get; set; }
        public string? Describe { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Frequency { get; set; }
        public string? State { get; set; }
        public string? FrequencyString { get; set; }
        public long Id { get; set; }
        public long? Pid { get; set; }
        public string? Remark { get; set; }
        public string? PrjProgressId { get; set; }
        public decimal? SectionExcavateDepth { get; set; }
        public decimal? SectionExcavateArea { get; set; }

        public virtual ICollection<TConstructionStage> TConstructionStages { get; set; }
    }
}
