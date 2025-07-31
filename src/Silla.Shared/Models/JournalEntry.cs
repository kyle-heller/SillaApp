namespace Silla.Shared.Models;

public class JournalEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid FamilyId { get; set; }
    public Guid AuthorId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Title { get; set; } = "";
    public string Body { get; set; } = "";
}