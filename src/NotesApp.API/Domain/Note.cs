namespace NotesApp.API.Domain;

public class Note
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ContentMarkdown { get; set; } = "";
    public string ContentHtml { get; set; } = "";
    public bool IsPinned { get; set; }
    public bool IsArchived { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<NoteTag> NoteTags { get; set; } = [];
}