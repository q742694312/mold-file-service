using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class MMetroSection
    {
        public int MetroSectionId { get; set; }
        public string? SectionName { get; set; }
        public string? SectionCode { get; set; }
        public DateTime? SectionOpenTime { get; set; }
        public int? MetroId { get; set; }
        public string? SectionRemark { get; set; }
        public int? SectionIsDel { get; set; }
        public string? SectionDelTime { get; set; }
    }
}
