using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class BaseFileRecord
    {
        public int Id { get; set; }
        public int ProjectCount { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public string? Type { get; set; }
        public string? UpdateUser { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
