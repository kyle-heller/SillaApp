using Microsoft.EntityFrameworkCore;
using Silla.Shared.Models;

namespace Silla.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts)
            : base(opts)
        { }

        public DbSet<JournalEntry> JournalEntries { get; set; } = null!;
    }
}