using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class JobTable
    {
        public short Id { get; set; }
        public string TableName { get; set; } = null!;
        public string? CName { get; set; }
        public byte? TransFg { get; set; }
        public int Tid { get; set; }
    }
}
