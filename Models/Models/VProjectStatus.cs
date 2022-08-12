using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class VProjectStatus
    {
        public string DataSource { get; set; } = null!;
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? ProType { get; set; }
        public string? ProStatus { get; set; }
        public string? Describe { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
