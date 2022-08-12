using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YPrjStatus
    {
        public int? PrjId { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int Identity { get; set; }
        public decimal? SectionExcavateDepth { get; set; }
        public decimal? SectionExcavateArea { get; set; }
    }
}
