using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GlacierDIS.Models.Mapping
{
    public class ImportHeaderMap : EntityTypeConfiguration<ImportHeader>
    {
        public ImportHeaderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ImportHeader");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ProcessingMonth).HasColumnName("ProcessingMonth");
            this.Property(t => t.ProcessingStatus).HasColumnName("ProcessingStatus");
        }
    }
}
