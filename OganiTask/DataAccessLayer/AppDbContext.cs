using Microsoft.EntityFrameworkCore;
using OganiTask.DataAccessLayer.Entities;

namespace OganiTask.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categories>? Categories { get; set; }

        public DbSet<Products>? Products { get; set; }

        public DbSet<Blogs>? Blogs { get; set; }

        public DbSet<CaruselProduct> CaruselProducts { get; set;}

        public DbSet<GridProducts> GridProducts { get; set; }

        public DbSet<Widget> Widget { get; set; }

    }
}
