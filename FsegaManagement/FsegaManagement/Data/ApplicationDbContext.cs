using FsegaManagement.Configs.Entitati;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FsegaManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<Angajat>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
        public DbSet<TipConcediu> TipConcedii { get; set; }
        public DbSet<ConcediuAlocat> ConcediiAlocate { get; set; }
    }
}