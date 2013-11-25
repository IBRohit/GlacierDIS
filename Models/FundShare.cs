using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class FundShare
    {
        public FundShare()
        {
            this.FundShareIndexes = new List<FundShareIndex>();
            this.ImportAudits = new List<ImportAudit>();
            this.ImportErrors = new List<ImportError>();
        }

        public int Id { get; set; }
        public string FundShareClassId { get; set; }
        public string FundId { get; set; }
        public string ExternalId { get; set; }
        public string CountryId { get; set; }
        public string Name { get; set; }
        public string IndexLegalName { get; set; }
        public string Isin { get; set; }
        public System.DateTime InceptionDate { get; set; }
        public string CurrencyIso { get; set; }
        public string CurrencyName { get; set; }
        public System.DateTime FundLastUpdated { get; set; }
        public virtual ICollection<FundShareIndex> FundShareIndexes { get; set; }
        public virtual ICollection<ImportAudit> ImportAudits { get; set; }
        public virtual ICollection<ImportError> ImportErrors { get; set; }
    }
}
