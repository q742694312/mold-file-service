using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SysDepartment
    {
        public SysDepartment()
        {
            SysUsers = new HashSet<SysUser>();
        }

        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }

        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
