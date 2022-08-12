using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YPrjStatusImage
    {
        public int? PrjId { get; set; }
        public string? Url { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public int Identity { get; set; }
    }
}
