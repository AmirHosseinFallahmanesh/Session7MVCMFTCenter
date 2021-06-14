using Demo.Domain.Entittes;
using Demo.Infrastructure.DAL.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.DAL
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=SCHOOLDEMO;Trusted_Connection=True;"); 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}
