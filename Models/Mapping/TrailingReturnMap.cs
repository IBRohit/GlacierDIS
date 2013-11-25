using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class TrailingReturnMap : EntityTypeConfiguration<TrailingReturn>
    {
        public TrailingReturnMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("TrailingReturns");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FundShareIndexId).HasColumnName("FundShareIndexId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
            this.Property(t => t.PriceDate).HasColumnName("PriceDate");

            // Relationships
            this.HasRequired(t => t.FundShareIndex)
                .WithMany(t => t.TrailingReturns)
                .HasForeignKey(d => d.FundShareIndexId);

        }
    }
}
