namespace NotesApp.API.DTOs;

public record CreateTagRequest(string Name, string Color);
public record UpdateTagRequest(string Name, string Color);
public record TagResponse(Guid Id, string Name, string Color);