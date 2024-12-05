namespace PhotosMvc.Models;

public class Photo
{
    public int Id { get; set; }
    public required string ThumbnailUrl { get; set; }
    public required string Description { get; set; }
}
