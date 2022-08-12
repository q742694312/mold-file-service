using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SysModule
    {
        public int ModuleId { get; set; }
        public string? ModuleName { get; set; }
        public string? ModuleUrl { get; set; }
        public int ParentModule { get; set; }
        public bool Isdelete { get; set; }
    }
}
