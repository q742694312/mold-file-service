using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class SysUser
    {
        public int UserId { get; set; }
        public string? UserNumber { get; set; }
        public string UserName { get; set; } = null!;
        public string UserLoginId { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public DateTime? UserBirthday { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public int? DepartmentId { get; set; }
        public int? RoleId { get; set; }

        public virtual SysDepartment? Department { get; set; }
        public virtual SysRole? Role { get; set; }
    }
}
