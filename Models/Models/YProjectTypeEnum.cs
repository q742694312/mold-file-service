using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class YProjectTypeEnum
    {
        public YProjectTypeEnum()
        {
            YProjects = new HashSet<YProject>();
        }

        public string ProjectType { get; set; } = null!;
        public string? Name { get; set; }
        public int? Sequence { get; set; }

        public virtual ICollection<YProject> YProjects { get; set; }
    }
}
