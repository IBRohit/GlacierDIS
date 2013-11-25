using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class PortfolioHoldingMap : EntityTypeConfiguration<PortfolioHolding>
    {
        public PortfolioHoldingMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.ExternalId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SectorId)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.DetailHoldingTypeId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.SecurityName)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Isin)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Cusip)
                .HasMaxLength(100);

            this.Property(t => t.CountryId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.CurrencyId)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Currency)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PortfolioHolding");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FundShareIndexId).HasColumnName("FundShareIndexId");
            this.Property(t => t.ExternalId).HasColumnName("ExternalId");
            this.Property(t => t.SectorId).HasColumnName("SectorId");
            this.Property(t => t.DetailHoldingTypeId).HasColumnName("DetailHoldingTypeId");
            this.Property(t => t.SecurityName).HasColumnName("SecurityName");
            this.Property(t => t.SummaryDate).HasColumnName("SummaryDate");
            this.Property(t => t.Isin).HasColumnName("Isin");
            this.Property(t => t.Cusip).HasColumnName("Cusip");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.Currency).HasColumnName("Currency");
            this.Property(t => t.MaturityDate).HasColumnName("MaturityDate");
            this.Property(t => t.Coupon).HasColumnName("Coupon");
            this.Property(t => t.Weighting).HasColumnName("Weighting");
            this.Property(t => t.NumberOfShare).HasColumnName("NumberOfShare");
            this.Property(t => t.MarketValue).HasColumnName("MarketValue");
            this.Property(t => t.ShareChange).HasColumnName("ShareChange");

            // Relationships
            this.HasRequired(t => t.FundShareIndex)
                .WithMany(t => t.PortfolioHoldings)
                .HasForeignKey(d => d.FundShareIndexId);

        }
    }
}
