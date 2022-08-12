using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class RegionModel
    {
        public int Id { get; set; }
        public int RegionId { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Engineering { get; set; }
        public string? Url { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string? UpdateUser { get; set; }
        public int? IsDelete { get; set; }
        public string? Remark { get; set; }
    }
}
