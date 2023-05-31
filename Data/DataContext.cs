global using Microsoft.EntityFrameworkCore;

namespace Net7CoreAPIFULL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server =(local); database = Net7APICore;uid=sa;pwd=234555ax; Integrated security = True; TrustServerCertificate=True;");
        }
        public DbSet<Superhero> Superheroes { get; set; }
    }
}
