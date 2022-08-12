using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class ThreeProject
    {
        public int Id { get; set; }
        public string ProjectName { get; set; } = null!;
        public string ModelId { get; set; } = null!;
    }
}
