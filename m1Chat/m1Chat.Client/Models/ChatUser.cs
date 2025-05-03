namespace m1Chat.Client.Models;

public class ChatUser
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? AvatarUrl { get; set; }
    // Add other user properties if needed
}