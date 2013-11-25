using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class TrailingReturn
    {
        public TrailingReturn()
        {
            this.TrailingReturnsDetails = new List<TrailingReturnsDetail>();
        }

        public int Id { get; set; }
        public int FundShareIndexId { get; set; }
        public byte Type { get; set; }
        public System.DateTime EndDate { get; set; }
        public decimal ClosePrice { get; set; }
        public System.DateTime PriceDate { get; set; }
        public virtual FundShareIndex FundShareIndex { get; set; }
        public virtual ICollection<TrailingReturnsDetail> TrailingReturnsDetails { get; set; }
    }
}
