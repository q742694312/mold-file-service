using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YProjectDocument
    {
        public int Id { get; set; }
        public int PrjId { get; set; }
        public string Type { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Ext { get; set; } = null!;
        public DateTime Date { get; set; }
        public string UploadUser { get; set; } = null!;
        public int? VisibleToOwner { get; set; }
    }
}
