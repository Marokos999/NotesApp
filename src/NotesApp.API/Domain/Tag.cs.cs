namespace NotesApp.API.Domain;

public class Tag
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Color { get; set; } = "#6B7280";
    public ICollection<NoteTag> NoteTags { get; set; } = [];
}