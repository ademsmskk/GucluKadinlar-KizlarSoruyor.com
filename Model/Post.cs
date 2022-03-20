public class Post
{

    public int Id { get; set; }
    public string Content { get; set; }
    public DateTime DateTime { get; set; }
    public int? LikeCount { get; set; }
    public Category? Category { get; set; }
    public int? CategoryId { get; set; }
    public Title? Title { get; set; }
    public int TitleId { get; set; }
    public User? User { get; set; }
    public int UserId { get; set; }
    public virtual ICollection<Comment>? Comment { get; set; }
    public virtual ICollection<Picture>? Picture { get; set; }



}