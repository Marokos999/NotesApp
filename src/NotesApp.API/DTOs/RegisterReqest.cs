namespace NotesApp.API.DTOs;

public record RegisterReqest(string Email, string Password);
public  record LoginReqest(string Email, string Password);
public record RefreshTokenReqest(string RefreshToken);
public record AuthResponse(string AccessToken, string RefreshToken, DateTime ExpiresAt, string Email);