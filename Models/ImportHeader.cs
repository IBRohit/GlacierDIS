using System;
using System.Collections.Generic;

namespace GlacierDIS.Models
{
    public partial class ImportHeader
    {
        public ImportHeader()
        {
            this.FundShareIndexes = new List<FundShareIndex>();
            this.ImportAudits = new List<ImportAudit>();
            this.ImportErrors = new List<ImportError>();
        }

        public int Id { get; set; }
        public System.DateTime ProcessingMonth { get; set; }
        public byte ProcessingStatus { get; set; }
        public virtual ICollection<FundShareIndex> FundShareIndexes { get; set; }
        public virtual ICollection<ImportAudit> ImportAudits { get; set; }
        public virtual ICollection<ImportError> ImportErrors { get; set; }
    }
}
