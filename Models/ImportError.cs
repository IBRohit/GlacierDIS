using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class ImportError
    {
        public int Id { get; set; }
        public int ImportHeaderId { get; set; }
        public Nullable<int> FundShareId { get; set; }
        public byte ErrorType { get; set; }
        public string ErrorMessage { get; set; }
        public bool Processed { get; set; }
        public System.DateTime OccurredAt { get; set; }
        public virtual FundShare FundShare { get; set; }
        public virtual ImportHeader ImportHeader { get; set; }
    }
}
