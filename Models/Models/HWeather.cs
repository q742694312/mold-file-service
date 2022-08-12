using System;
using System.Collections.Generic;

namespace Models.Models
{
    public partial class HWeather
    {
        public DateTime? Date { get; set; }
        public string? City { get; set; }
        public double? MaxTemper { get; set; }
        public double? MinTemper { get; set; }
        public string? Weather { get; set; }
        public string? Wind { get; set; }
        public string? WindLevel { get; set; }
        public int Id { get; set; }
    }
}
