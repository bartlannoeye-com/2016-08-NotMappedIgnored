using Microsoft.EntityFrameworkCore;

namespace NotMappedIgnored.Data
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename=Configuration.db");
        }
    }
}
