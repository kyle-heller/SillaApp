using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Silla.Infrastructure.Data
{
    public class AppDbContextFactory
        : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseNpgsql(
                "Host=localhost;Port=5432;Database=silla;Username=silla;Password=<YOUR_PASSWORD>");
            return new AppDbContext(builder.Options);
        }
    }
}