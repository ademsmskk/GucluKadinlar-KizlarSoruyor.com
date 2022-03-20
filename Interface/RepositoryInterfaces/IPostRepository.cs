public interface IPostRepository
{

    Task<List<Post>> GetAllPosts();
    Task<List<Post>> GetAllPostByTitleId(int id);
    Task<List<Post>> GetAllPostByTitleName(string name);
    Task<Post> CreatePost(Post post);
    Task<List<Post>> GetAllPostsOfUsersByUserId(int id);
    Task<Post> GetPostByPostId(int id);
    Task<Title> GetTitleById(int Id);
    Task<Title> GetTitleByName(string Name);
    Task<User> GetUserByUserId(int id);
    Task<Post> UpdatePost(Post post);
    Task<Post> DeletePost(Post post);
    Task<Post> UpdateLikeCountPost(Post post);


}

