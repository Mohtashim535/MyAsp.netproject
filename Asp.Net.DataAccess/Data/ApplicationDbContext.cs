using Microsoft.EntityFrameworkCore;
using MyAsp.NetProject.Models;

namespace MyAsp.NetProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public  DbSet <Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData (
                new Category { Id=1, Name="Mohammad" , DisplayOrder=1},
                new Category { Id=2, Name="Mohtashim" , DisplayOrder=2},
                new Category { Id=3, Name="Ansari" , DisplayOrder=3},
                new Category { Id=4, Name="Mohtashim" , DisplayOrder=4}
                );
        }
    }
}
