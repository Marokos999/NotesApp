namespace NotesApp.API.Domain;

public class RefreshToken
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public ApplicationUser User { get; set; } = null!;
    public string Token { get; set; } = null!;
    public bool IsRevoked { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}