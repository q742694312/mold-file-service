using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Dyntable
    {
        public string? Ftablecode { get; set; }
        public string? Fname { get; set; }
        public byte[]? Fdata { get; set; }
        public int Tid { get; set; }
    }
}
