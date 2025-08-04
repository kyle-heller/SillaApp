using Microsoft.EntityFrameworkCore;
using Silla.Infrastructure.Data; // your DbContext
using Silla.Shared.Models;        // JournalEntry
namespace Silla.Infrastructure.Repositories
{
    public class JournalEntryRepository : IJournalEntryRepository
    {
        private readonly AppDbContext _db;
        public JournalEntryRepository(AppDbContext db) => _db = db;

        public async Task<IEnumerable<JournalEntry>> GetAllAsync() =>
            await _db.JournalEntries.ToListAsync();

        public async Task<JournalEntry?> GetByIdAsync(Guid id) =>
            await _db.JournalEntries.FindAsync(id);

        public async Task AddAsync(JournalEntry entry)
        {
            await _db.JournalEntries.AddAsync(entry);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(JournalEntry entry)
        {
            _db.JournalEntries.Update(entry);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var e = await _db.JournalEntries.FindAsync(id);
            if (e != null)
            {
                _db.JournalEntries.Remove(e);
                await _db.SaveChangesAsync();
            }
        }
    }
}