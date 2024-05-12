using Microsoft.EntityFrameworkCore;


namespace dz_filter
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dzfilter.db");
        }
    }
}
