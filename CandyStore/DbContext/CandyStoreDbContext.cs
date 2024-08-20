using Microsoft.EntityFrameworkCore;

namespace CandyStore.DbContext
{
    public class CandyStoreDbContext : DbContext
    {
        public DbSet<Candy> Candy { get; set;};

        public overide OnModelCreating(ModelBuilder modelbuilder) 
        {
            modelbuilder.Entity<Candy>.ToTable("Candy");
        }
    }
}
