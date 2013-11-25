using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using GlacierDIS.Models.Mapping;

namespace GlacierDIS.Models
{
    public partial class GlacierDISContext : DbContext
    {
        static GlacierDISContext()
        {
            Database.SetInitializer<GlacierDISContext>(null);
        }

        public GlacierDISContext()
            : base("Name=GlacierDISContext")
        {
        }

        public DbSet<FundShare> FundShares { get; set; }
        public DbSet<FundShareIndex> FundShareIndexes { get; set; }
        public DbSet<ImportAudit> ImportAudits { get; set; }
        public DbSet<ImportError> ImportErrors { get; set; }
        public DbSet<ImportHeader> ImportHeaders { get; set; }
        public DbSet<PortfolioHolding> PortfolioHoldings { get; set; }
        public DbSet<RiskMeasure> RiskMeasures { get; set; }
        public DbSet<TrailingReturn> TrailingReturns { get; set; }
        public DbSet<TrailingReturnsDetail> TrailingReturnsDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FundShareMap());
            modelBuilder.Configurations.Add(new FundShareIndexMap());
            modelBuilder.Configurations.Add(new ImportAuditMap());
            modelBuilder.Configurations.Add(new ImportErrorMap());
            modelBuilder.Configurations.Add(new ImportHeaderMap());
            modelBuilder.Configurations.Add(new PortfolioHoldingMap());
            modelBuilder.Configurations.Add(new RiskMeasureMap());
            modelBuilder.Configurations.Add(new TrailingReturnMap());
            modelBuilder.Configurations.Add(new TrailingReturnsDetailMap());
        }
    }
}
