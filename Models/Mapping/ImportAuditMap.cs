using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class ImportAuditMap : EntityTypeConfiguration<ImportAudit>
    {
        public ImportAuditMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ImportAudit");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImportHeaderId).HasColumnName("ImportHeaderId");
            this.Property(t => t.FundShareId).HasColumnName("FundShareId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TimeStart).HasColumnName("TimeStart");
            this.Property(t => t.TimeEnd).HasColumnName("TimeEnd");

            // Relationships
            this.HasRequired(t => t.FundShare)
                .WithMany(t => t.ImportAudits)
                .HasForeignKey(d => d.FundShareId);
            this.HasRequired(t => t.ImportHeader)
                .WithMany(t => t.ImportAudits)
                .HasForeignKey(d => d.ImportHeaderId);

        }
    }
}
