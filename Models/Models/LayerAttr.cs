using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class LayerAttr
    {
        public string Name { get; set; } = null!;
        public string? FChar { get; set; }
        public bool Useradd { get; set; }
        public byte[]? Data { get; set; }
        public int Tid { get; set; }
    }
}
