using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class HydrogeologicalZone
    {
        public int Id { get; set; }
        public long? Objectid { get; set; }
        public float? ShapeLeng { get; set; }
        public float? ShapeArea { get; set; }
        public string? Color { get; set; }
        public string? Name { get; set; }
        public string? Belong { get; set; }
    }
}
