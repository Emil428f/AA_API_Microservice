using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Gps> Gps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }



    public interface IApplicationDbContext
    {
        DbSet<Gps> Gps { get;}
    }
}
