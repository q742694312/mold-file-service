using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class PileFile
    {
        public int Id { get; set; }
        public int Projectid { get; set; }
        public string? Projectname { get; set; }
        public string? Filename { get; set; }
        public string? Filetype { get; set; }
        public string? Url { get; set; }
        public DateTime? Uploadtime { get; set; }
        public int? UploadId { get; set; }
        public DateTime? DeleteTime { get; set; }
        public int? DeleteId { get; set; }
        public bool? IsDelte { get; set; }
    }
}
