using Microsoft.AspNetCore.Identity;

namespace NotesApp.API.Domain;

public class ApplicationUser : IdentityUser
{
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<Note> Notes { get; set; } = [];
    public ICollection<Tag> Tags { get; set; } = [];
    public ICollection<RefreshToken> RefreshTokens { get; set; } = [];
}