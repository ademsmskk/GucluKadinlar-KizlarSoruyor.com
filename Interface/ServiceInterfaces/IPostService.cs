public interface IPostService
{

    Task<ServiceResponse< List<Post>>> GetAllPosts();
    Task<ServiceResponse<List<Post>>> GetAllPostByTitleId(int id);
    Task<ServiceResponse<List<Post>>> GetAllPostByTitleName(string name);
    Task<ServiceResponse<Post>> CreatePost(Post post);
    Task<ServiceResponse<List<Post>>> GetAllPostsOfUsersByUserId(int id);
    Task<ServiceResponse<Post>> GetPostByPostId(int id);
    Task<ServiceResponse<Post>> UpdatePost(PostUpdateDTO post);
    Task<ServiceResponse<Post>> DeletePost(int id);
    Task<ServiceResponse<Post>> UpdateLikeCountPost(PostUpdateDTO post);

}