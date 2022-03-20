[Serializable]
public class PostService : IPostService
{
    private readonly IPostRepository _PostRepository;
    public PostService(IPostRepository postRepository)
    {

        _PostRepository = postRepository;
    }




    async Task<ServiceResponse<Post>> IPostService.CreatePost(Post post)
    {
        ServiceResponse<Post> response = new ServiceResponse<Post>();

        try
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.CreatePost(post);
            return response;
        }
        catch (System.Exception)
        {

            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }

    }

    async Task<ServiceResponse<Post>> IPostService.DeletePost(int id)
    {
        ServiceResponse<Post> response = new ServiceResponse<Post>();

        Post finder = await _PostRepository.GetPostByPostId(id);
        if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.PostDeleteSuccess;
            response.Data = await _PostRepository.DeletePost(finder);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PostDeleteOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<List<Post>>> IPostService.GetAllPostByTitleId(int id)
    {
        ServiceResponse<List<Post>> response = new ServiceResponse<List<Post>>();
        Title finderTitleid = await _PostRepository.GetTitleById(id);
        if (finderTitleid != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.GetAllPostByTitleId(id);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }


    }
    public async Task<ServiceResponse<List<Post>>> GetAllPostByTitleName(string name)
    {
        ServiceResponse<List<Post>> response = new ServiceResponse<List<Post>>();
        Title finderTitleName = await _PostRepository.GetTitleByName(name);
        if (finderTitleName != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.GetAllPostByTitleName(name);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }
    }

    public async Task<ServiceResponse<List<Post>>> GetAllPosts()
    {
        ServiceResponse<List<Post>> response = new ServiceResponse<List<Post>>();
        try
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.GetAllPosts();
            return response;
        }
        catch (System.Exception)
        {

            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }
    }

    public async Task<ServiceResponse<List<Post>>> GetAllPostsOfUsersByUserId(int id)
    {

        ServiceResponse<List<Post>> response = new ServiceResponse<List<Post>>();

        User finderUserById = await _PostRepository.GetUserByUserId(id);
        if (finderUserById != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.GetAllPostsOfUsersByUserId(id);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }
    }

    async public Task<ServiceResponse<Post>> GetPostByPostId(int id)
    {

        ServiceResponse<Post> response = new ServiceResponse<Post>();

        Post finderPostById = await _PostRepository.GetPostByPostId(id);
        if (finderPostById != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.GetPostByPostId(id);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }
    }

    public async Task<ServiceResponse<Post>> UpdatePost(PostUpdateDTO post)
    {
        ServiceResponse<Post> response = new ServiceResponse<Post>();
        var updatedPost = await _PostRepository.GetPostByPostId(post.Id);
        if (updatedPost != null)
        {

            updatedPost.Content = post.Content;
            updatedPost.DateTime = post.DateTime;

            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.UpdatePost(updatedPost);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }

    }

    async Task<ServiceResponse<Post>> IPostService.UpdateLikeCountPost(PostUpdateDTO post)
    {
        ServiceResponse<Post> response = new ServiceResponse<Post>();
        Post updatedPost = await _PostRepository.GetPostByPostId(post.Id);
        if (updatedPost != null)
        {

            updatedPost.LikeCount = post.LikeCount + 1;
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _PostRepository.UpdatePost(updatedPost);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.PostOperationFail;
            return response;
        }


    }
}