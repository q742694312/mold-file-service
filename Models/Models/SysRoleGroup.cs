using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SysRoleGroup
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? ModuleId { get; set; }
        public string? ActionName { get; set; }
        public int ParentId { get; set; }
    }
}
