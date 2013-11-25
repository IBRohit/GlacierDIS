using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class TrailingReturnsDetailMap : EntityTypeConfiguration<TrailingReturnsDetail>
    {
        public TrailingReturnsDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TimePeriod)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("TrailingReturnsDetail");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.TrailingReturnsId).HasColumnName("TrailingReturnsId");
            this.Property(t => t.TimePeriod).HasColumnName("TimePeriod");
            this.Property(t => t.Value).HasColumnName("Value");

            // Relationships
            this.HasRequired(t => t.TrailingReturn)
                .WithMany(t => t.TrailingReturnsDetails)
                .HasForeignKey(d => d.TrailingReturnsId);

        }
    }
}
