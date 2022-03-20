public class Title
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Post>? Post { get; set; }

}