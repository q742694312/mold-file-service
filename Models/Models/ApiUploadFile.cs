using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ApiUploadFile
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public string? ProType { get; set; }
        public string? LoginId { get; set; }
        public DateTime? Uptime { get; set; }
        public string? Path { get; set; }
        public int? DelShow { get; set; }
        public string? Filename { get; set; }
    }
}
