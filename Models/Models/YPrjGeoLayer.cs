using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YPrjGeoLayer
    {
        public string Json { get; set; } = null!;
        public int PrjId { get; set; }
        public string LayerName { get; set; } = null!;
        public string? Remark { get; set; }
        public int? Sequence { get; set; }
        public int Identity { get; set; }
    }
}
