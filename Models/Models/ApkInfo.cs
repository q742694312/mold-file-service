using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ApkInfo
    {
        public int Id { get; set; }
        public string? RecordId { get; set; }
        public string? Version { get; set; }
        public string? Path { get; set; }
        public DateTime? AddTime { get; set; }
        public string? Content { get; set; }
    }
}
