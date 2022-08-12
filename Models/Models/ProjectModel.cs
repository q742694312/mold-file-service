using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ProjectModel
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Engineering { get; set; }
        public string? Url { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public int? IsDelete { get; set; }
        public byte[]? Remark { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? RHeight { get; set; }
        public double? RRotate { get; set; }
    }
}
