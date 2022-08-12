using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class TMonitorProject
    {
        public TMonitorProject()
        {
            TMonitorProjectSettings = new HashSet<TMonitorProjectSetting>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Note { get; set; }
        public string? Icon { get; set; }
        public int? DisplayOrder { get; set; }
        public string? MeasureUnit { get; set; }
        public int? DecimalDigits { get; set; }
        public long? DataTypeId { get; set; }
        public long? Pid { get; set; }
        public string? MonitorProjectId { get; set; }

        public virtual TMonitorDataType? DataType { get; set; }
        public virtual ICollection<TMonitorProjectSetting> TMonitorProjectSettings { get; set; }
    }
}
