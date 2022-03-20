using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private readonly ICommentService _commentService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet("id")]
    public async Task<ActionResult<ServiceResponse<Comment>>> GetCommentById(int id)
    {
        return await _commentService.GetCommentById(id);
    }
    [HttpGet("Postid")]
    public async Task<ActionResult<ServiceResponse<List<Comment>>>> GetAllCommentByPostId(int id)
    {
        return await _commentService.GetAllCommentByPostId(id);
    }
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Comment>>> CreateComment(Comment comment)
    {
        return await _commentService.CreateComment(comment);

    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Comment>>> UpdateCommentById(CommentUpdateDTO comment)
    {
        return await _commentService.UpdateCommentById(comment);
    }
    [HttpPut("like")]
    public async Task<ActionResult<ServiceResponse<Comment>>> UpdateLikeCountComment(CommentUpdateDTO comment)
    {
        return await _commentService.UpdateLikeCountComment(comment);
    }
    [HttpDelete("Deleteid")]
    public async Task<ServiceResponse<Comment>> DeleteComment(int id)
    {

        return await _commentService.DeleteComment(id);


    }

}