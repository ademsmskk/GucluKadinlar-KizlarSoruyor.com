using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

[AllowAnonymous]
public class PostController : ControllerBase
{
    private readonly IPostService _PostService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public PostController(IPostService PostService)
    {
        _PostService = PostService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Post>>>> GetAllPost()
    {
        return await _PostService.GetAllPosts();
    }




    [HttpGet("titleid")]
    public async Task<ActionResult<ServiceResponse<List<Post>>>> GetAllPostByTitleId(int id)
    {
        return await _PostService.GetAllPostByTitleId(id);
    }

    [HttpGet("titlename")]
    public async Task<ActionResult<ServiceResponse<List<Post>>>> GetAllPostByTitleName(string name)
    {
        return await _PostService.GetAllPostByTitleName(name);
    }

    [HttpGet("userid")]
    public async Task<ActionResult<ServiceResponse<List<Post>>>> GetAllPostsOfUsersByUserId(int id)
    {
        return await _PostService.GetAllPostsOfUsersByUserId(id);
    }

    [HttpGet("postid")]
    public async Task<ActionResult<ServiceResponse<Post>>> GetPostByPostId(int id)
    {
        return await _PostService.GetPostByPostId(id);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Post>>> CreatePost(Post Post)
    {
        return await _PostService.CreatePost(Post);
    }


    [HttpDelete("id")]
    public async Task<ActionResult<ServiceResponse<Post>>> DeletePost(int id)
    {
        return await _PostService.DeletePost(id);
    }
    [HttpPut("like")]
    public async Task<ActionResult<ServiceResponse<Post>>> UpdateLikeCountComment(PostUpdateDTO post)
    {
        return await _PostService.UpdateLikeCountPost(post);
    }

    [HttpPut("update")]
    public async Task<ActionResult<ServiceResponse<Post>>> UpdatePostById(PostUpdateDTO Post)
    {
        return await _PostService.UpdatePost(Post);

    }







}