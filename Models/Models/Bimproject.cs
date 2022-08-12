using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Bimproject
    {
        public int Id { get; set; }
        public string? Id1 { get; set; }
        public string? Modelid { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Address { get; set; }
        public string? Manager { get; set; }
        public string? Summarizes { get; set; }
        public string? Prjlevel { get; set; }
        public string? Prjtype { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string? Projurl { get; set; }
    }
}
