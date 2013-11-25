using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class RiskMeasureMap : EntityTypeConfiguration<RiskMeasure>
    {
        public RiskMeasureMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.TimePeriod)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("RiskMeasures");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FundShareIndexId).HasColumnName("FundShareIndexId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.TimePeriod).HasColumnName("TimePeriod");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.IsQuarterly).HasColumnName("IsQuarterly");
            this.Property(t => t.ArithmeticMean).HasColumnName("ArithmeticMean");
            this.Property(t => t.StandardDeviation).HasColumnName("StandardDeviation");
            this.Property(t => t.SharpeRatio).HasColumnName("SharpeRatio");
            this.Property(t => t.Skewness).HasColumnName("Skewness");
            this.Property(t => t.Kurtosis).HasColumnName("Kurtosis");
            this.Property(t => t.SortinoRatio).HasColumnName("SortinoRatio");

            // Relationships
            this.HasRequired(t => t.FundShareIndex)
                .WithMany(t => t.RiskMeasures)
                .HasForeignKey(d => d.FundShareIndexId);

        }
    }
}
