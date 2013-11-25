using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class PortfolioHolding
    {
        public int Id { get; set; }
        public int FundShareIndexId { get; set; }
        public string ExternalId { get; set; }
        public string SectorId { get; set; }
        public string DetailHoldingTypeId { get; set; }
        public string SecurityName { get; set; }
        public System.DateTime SummaryDate { get; set; }
        public string Isin { get; set; }
        public string Cusip { get; set; }
        public string CountryId { get; set; }
        public string Country { get; set; }
        public string CurrencyId { get; set; }
        public string Currency { get; set; }
        public System.DateTime MaturityDate { get; set; }
        public Nullable<decimal> Coupon { get; set; }
        public Nullable<decimal> Weighting { get; set; }
        public Nullable<decimal> NumberOfShare { get; set; }
        public Nullable<decimal> MarketValue { get; set; }
        public Nullable<decimal> ShareChange { get; set; }
        public virtual FundShareIndex FundShareIndex { get; set; }
    }
}
