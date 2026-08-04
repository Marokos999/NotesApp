namespace NotesApp.API.DTOs;

public record CreateNoteRequest(string Title, string ContentMarkdown, List<Guid>? TagIds);

public record UpdateNoteRequest(
    string Title,
    string ContentMarkdown,
    bool IsPinned,
    bool IsArchived,
    List<Guid>? TagIds);

public record NoteResponse(
    Guid Id,
    string Title,
    string ContentMarkdown,
    string ContentHtml,
    bool IsPinned,
    bool IsArchived,
    DateTime CreatedAt,
    DateTime UpdatedAt,
    List<TagResponse> Tags);