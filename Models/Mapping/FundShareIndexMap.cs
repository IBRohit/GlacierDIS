using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class FundShareIndexMap : EntityTypeConfiguration<FundShareIndex>
    {
        public FundShareIndexMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("FundShareIndex");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImportHeaderId).HasColumnName("ImportHeaderId");
            this.Property(t => t.FundShareId).HasColumnName("FundShareId");

            // Relationships
            this.HasRequired(t => t.FundShare)
                .WithMany(t => t.FundShareIndexes)
                .HasForeignKey(d => d.FundShareId);
            this.HasRequired(t => t.ImportHeader)
                .WithMany(t => t.FundShareIndexes)
                .HasForeignKey(d => d.ImportHeaderId);

        }
    }
}
