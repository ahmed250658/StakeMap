using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StakeMap.Infrastructure.Entities;
using StakeMap.Infrastructure.Entities.Identity;

namespace StakeMap.Infrastructure.Context
{
    // StakeMap.Data/AppDbContext.cs
    public class AppDbContext : IdentityDbContext<Users, Role, int, IdentityUserClaim<int>, IdentityUserRole<int>, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ContactSubmissions> ContactSubmissions { get; set; }
        public DbSet<DashboardMetrics> DashboardMetrics { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<UserRefreshToken> userRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DashboardMetrics>()
                .HasIndex(d => d.MetricName)
                .IsUnique();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
