using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MFile
    {
        public int Id { get; set; }
        public int MetroId { get; set; }
        public string MetroName { get; set; } = null!;
        public string IntervalName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public DateTime? UpdateTime { get; set; }
        public string? UpdateUser { get; set; }
        public int? Type { get; set; }
        public string? FileName { get; set; }
        public string? UtfgridServer { get; set; }
        public string? CloudUrl { get; set; }
        public string? IntervalMap { get; set; }
    }
}
