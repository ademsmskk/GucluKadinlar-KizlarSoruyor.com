public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public int? PhoneNumber { get; set; }
    public Account? Account { get; set; }
    public int AccountId { get; set; }
    public virtual ICollection<Post>? Post { get; set; }
    public virtual ICollection<Comment>? Comment { get; set; }
    public virtual ICollection<Picture>? Picture { get; set; }


}