using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorDataType
    {
        public TMonitorDataType()
        {
            TMonitorProjects = new HashSet<TMonitorProject>();
        }

        public long Id { get; set; }
        public string? MeasureUnit { get; set; }
        public int? DecimalDigits { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public byte? IncludeSensor { get; set; }
        public byte? Visiable { get; set; }
        public string? ComponentType { get; set; }
        public string? MonitorDataTypeId { get; set; }

        public virtual ICollection<TMonitorProject> TMonitorProjects { get; set; }
    }
}
