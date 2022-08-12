using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TProjectImage
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public long? Pid { get; set; }
        public string? ImageType { get; set; }
        public string? ImagePath { get; set; }
        public string? ImageUrl { get; set; }
        public int? ImageLength { get; set; }
        public DateTime? UploadDate { get; set; }
        public string? UserName { get; set; }
        public string? ProjectImageId { get; set; }
    }
}
