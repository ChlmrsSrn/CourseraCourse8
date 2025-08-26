using Microsoft.EntityFrameworkCore;

namespace SafeVault.Data
{
    public class SafeVaultContext : DbContext
    {
        public SafeVaultContext(DbContextOptions<SafeVaultContext> options) : base(options)
        {
        }

        public DbSet<SafeVault.Models.User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SafeVault.Models.User>()
                .HasKey(u => u.UserID);
        }
    }
}