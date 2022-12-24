using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class EfDbContext: DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
        }

        public DbSet<BookEntity> Book { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<LibraryEntity> Library { get; set; }
    }
}