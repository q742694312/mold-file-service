using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Quanji
    {
        public int Id { get; set; }
        public string Quanji1 { get; set; } = null!;
        public string? Name { get; set; }
        public string? Belong { get; set; }
    }
}
