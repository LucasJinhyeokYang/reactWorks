using System.ComponentModel.DataAnnotations;
public class Post
{
    [Key]
    public int PostId { get; set; }
    public required string Title { get; set; }
    public string? Content { get; set; }
    public DateTime? PublishedDate { get; set; }
}