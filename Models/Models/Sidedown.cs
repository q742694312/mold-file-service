using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Sidedown
    {
        public int ProjectCount { get; set; }
        public int Hnumber { get; set; }
        public string TNo { get; set; } = null!;
        public int? Anumber { get; set; }
        public float Hhigh { get; set; }
        public float Thigh { get; set; }
        public float? Water { get; set; }
        public DateTime Testdate { get; set; }
        public float P { get; set; }
        public float A { get; set; }
        public float Po { get; set; }
        public float Py { get; set; }
        public float Pl { get; set; }
        public float Vc { get; set; }
        public float U { get; set; }
        public float H { get; set; }
        public byte NReforce { get; set; }
        public bool BShow { get; set; }
        public byte Dcount { get; set; }
        public byte[]? Data { get; set; }
        public byte NOption { get; set; }
        public int Tid { get; set; }
    }
}
