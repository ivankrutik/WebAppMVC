using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer
{
    public class EfDbContextFactory : IDesignTimeDbContextFactory<EfDbContext>
    {
        public EfDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EfDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-KQEGRRC;Database=LibraryDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True", b => b.MigrationsAssembly("DataLayer"));

            return new EfDbContext(optionsBuilder.Options);
        }
    }
}
