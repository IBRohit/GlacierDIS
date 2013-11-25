using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class ImportAudit
    {
        public int Id { get; set; }
        public int ImportHeaderId { get; set; }
        public int FundShareId { get; set; }
        public byte Type { get; set; }
        public System.DateTime TimeStart { get; set; }
        public System.DateTime TimeEnd { get; set; }
        public virtual FundShare FundShare { get; set; }
        public virtual ImportHeader ImportHeader { get; set; }
    }
}
