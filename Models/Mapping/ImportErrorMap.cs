using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class ImportErrorMap : EntityTypeConfiguration<ImportError>
    {
        public ImportErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ErrorMessage)
                .IsRequired()
                .HasMaxLength(8000);

            // Table & Column Mappings
            this.ToTable("ImportError");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImportHeaderId).HasColumnName("ImportHeaderId");
            this.Property(t => t.FundShareId).HasColumnName("FundShareId");
            this.Property(t => t.ErrorType).HasColumnName("ErrorType");
            this.Property(t => t.ErrorMessage).HasColumnName("ErrorMessage");
            this.Property(t => t.Processed).HasColumnName("Processed");
            this.Property(t => t.OccurredAt).HasColumnName("OccurredAt");

            // Relationships
            this.HasOptional(t => t.FundShare)
                .WithMany(t => t.ImportErrors)
                .HasForeignKey(d => d.FundShareId);
            this.HasRequired(t => t.ImportHeader)
                .WithMany(t => t.ImportErrors)
                .HasForeignKey(d => d.ImportHeaderId);

        }
    }
}
