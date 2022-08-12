using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Riverinterval
    {
        public int Id { get; set; }
        public int Riverid { get; set; }
        public int Sectionid { get; set; }
        public string? Intervalname { get; set; }
        public int? Sequence { get; set; }
    }
}
