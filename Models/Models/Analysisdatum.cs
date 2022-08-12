using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Analysisdatum
    {
        public int Prjid { get; set; }
        public string Location { get; set; } = null!;
        public string? Pointname { get; set; }
        public string? Holerelativeposition { get; set; }
        public string? Foundationrelativeposition { get; set; }
        public double? Initialconvergence { get; set; }
        public double? Tunneldepth { get; set; }
        public string? Geozone { get; set; }
        public double? UpPs { get; set; }
        public double? Ps { get; set; }
        public double? DownPs { get; set; }
        public double? MaxdigDepthvsDepth { get; set; }
        public double? DigArea { get; set; }
        public int Id { get; set; }
    }
}
