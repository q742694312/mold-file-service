using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TProjectFile
    {
        public long Id { get; set; }
        public long? Pid { get; set; }
        public string? Name { get; set; }
        public string? FileTyoe { get; set; }
        public string? FilePath { get; set; }
        public string? FileUrl { get; set; }
        public string? ProjectFileId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UserName { get; set; }
        public int? FileLength { get; set; }
    }
}
