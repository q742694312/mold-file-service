using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Baimo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int? Floor { get; set; }
        public double? Height { get; set; }
        public string? Belong { get; set; }
    }
}
