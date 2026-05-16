namespace BlogPostApplication.Models;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;  // Champion Name
    public string Content { get; set; } = string.Empty;  // Champion Description
    public string Author { get; set; } = string.Empty;  // Role/Class
    public string Role { get; set; } = string.Empty;  // Primary Role
    public string Difficulty { get; set; } = string.Empty;  // Difficulty Level
    public string Type { get; set; } = string.Empty;  // Champion Type
    public string ImageUrl { get; set; } = string.Empty;  // Champion Image URL
    public DateTime CreatedAt { get; set; }
}
