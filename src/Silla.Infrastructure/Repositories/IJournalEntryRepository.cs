using Silla.Shared.Models;
namespace Silla.Infrastructure.Repositories
{
    public interface IJournalEntryRepository
    {
        Task<IEnumerable<JournalEntry>> GetAllAsync();
        Task<JournalEntry?>   GetByIdAsync(Guid id);
        Task                  AddAsync(JournalEntry entry);
        Task                  UpdateAsync(JournalEntry entry);
        Task                  DeleteAsync(Guid id);
    }
}