using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class FundShareIndex
    {
        public FundShareIndex()
        {
            this.PortfolioHoldings = new List<PortfolioHolding>();
            this.RiskMeasures = new List<RiskMeasure>();
            this.TrailingReturns = new List<TrailingReturn>();
        }

        public int Id { get; set; }
        public int ImportHeaderId { get; set; }
        public int FundShareId { get; set; }
        public virtual FundShare FundShare { get; set; }
        public virtual ImportHeader ImportHeader { get; set; }
        public virtual ICollection<PortfolioHolding> PortfolioHoldings { get; set; }
        public virtual ICollection<RiskMeasure> RiskMeasures { get; set; }
        public virtual ICollection<TrailingReturn> TrailingReturns { get; set; }
    }
}
