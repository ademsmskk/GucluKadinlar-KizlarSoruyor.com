public class Picture
{

    public int Id { get; set; }
    public string? SmallPath { get; set; }
    public string? MiddlePath { get; set; }
    public string? BigPath { get; set; }
    public User? User { get; set; }
    public int? USerId { get; set; }
    public Post? Post { get; set; }
    public int? PostId { get; set; }
}