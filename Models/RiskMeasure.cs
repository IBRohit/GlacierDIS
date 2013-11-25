using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class RiskMeasure
    {
        public int Id { get; set; }
        public int FundShareIndexId { get; set; }
        public byte Type { get; set; }
        public string TimePeriod { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsQuarterly { get; set; }
        public Nullable<decimal> ArithmeticMean { get; set; }
        public Nullable<decimal> StandardDeviation { get; set; }
        public Nullable<decimal> SharpeRatio { get; set; }
        public Nullable<decimal> Skewness { get; set; }
        public Nullable<decimal> Kurtosis { get; set; }
        public Nullable<decimal> SortinoRatio { get; set; }
        public virtual FundShareIndex FundShareIndex { get; set; }
    }
}
