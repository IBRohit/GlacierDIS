using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class TrailingReturnsDetail
    {
        public int Id { get; set; }
        public int TrailingReturnsId { get; set; }
        public string TimePeriod { get; set; }
        public decimal Value { get; set; }
        public virtual TrailingReturn TrailingReturn { get; set; }
    }
}
