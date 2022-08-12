using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SysRole
    {
        public SysRole()
        {
            SysUsers = new HashSet<SysUser>();
        }

        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateName { get; set; }
        public string? RoleDescribe { get; set; }

        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
