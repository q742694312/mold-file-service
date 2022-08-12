using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectInfo
    {
        public string DataSource { get; set; } = null!;
        public long PrjId { get; set; }
        public string Name { get; set; } = null!;
        public string? ProjectType { get; set; }
    }
}
