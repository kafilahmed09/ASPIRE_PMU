using Microsoft.EntityFrameworkCore;


namespace ASPIRE.Data
{
    public class ApplicationDbContext : AuditableIdentityContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.Provience> Provience { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.Division> Division { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.District> District { get; set; }                
        public DbSet<ASPIRE.Models.Domain.MasterSetup.Tehsil> Tehsil { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.UnionCouncil> UnionCouncil { get; set; }               
        public DbSet<ASPIRE.Models.Domain.MasterSetup.AspireUserRole> AspireUserRole { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.School> School { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.Indicator> Indicator { get; set; }
        public DbSet<ASPIRE.Models.Domain.MasterSetup.FileType> FileType { get; set; }
        public DbSet<ASPIRE.Models.Domain.Schools.IndicatorEvidence> indicatorEvidence { get; set; }
        public DbSet<ASPIRE.Models.ViewModel.IndicatorwiseSummary> IndicatorwiseSummary { get; set; }               
    }
}
