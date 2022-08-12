using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class Pmlayer
    {
        public int ProjectCount { get; set; }
        public short Layerorder { get; set; }
        public string Layerno { get; set; } = null!;
        public string? Layername { get; set; }
        public short AgeNo { get; set; }
        public int Anumber { get; set; }
        public short? Layertype { get; set; }
        public string? LayerNameEn { get; set; }
        public int? LayerColor { get; set; }
        public byte[]? LayerAttr { get; set; }
    }
}
