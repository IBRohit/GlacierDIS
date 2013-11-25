using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class FundShareMap : EntityTypeConfiguration<FundShare>
    {
        public FundShareMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.FundShareClassId)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.FundId)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.ExternalId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CountryId)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.IndexLegalName)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.Isin)
                .IsRequired()
                .HasMaxLength(400);

            this.Property(t => t.CurrencyIso)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CurrencyName)
                .IsRequired()
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("FundShare");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FundShareClassId).HasColumnName("FundShareClassId");
            this.Property(t => t.FundId).HasColumnName("FundId");
            this.Property(t => t.ExternalId).HasColumnName("ExternalId");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IndexLegalName).HasColumnName("IndexLegalName");
            this.Property(t => t.Isin).HasColumnName("Isin");
            this.Property(t => t.InceptionDate).HasColumnName("InceptionDate");
            this.Property(t => t.CurrencyIso).HasColumnName("CurrencyIso");
            this.Property(t => t.CurrencyName).HasColumnName("CurrencyName");
            this.Property(t => t.FundLastUpdated).HasColumnName("FundLastUpdated");
        }
    }
}
