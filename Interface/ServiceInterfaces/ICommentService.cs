public interface ICommentService
{
    Task<ServiceResponse<List<Comment>>> GetAllCommentByPostId(int id);
    Task<ServiceResponse<Comment>> CreateComment(Comment comment);
    Task<ServiceResponse<Comment>> GetCommentById(int id);
    Task<ServiceResponse<Comment>> UpdateCommentById(CommentUpdateDTO comment);
    Task<ServiceResponse<Comment>> UpdateLikeCountComment(CommentUpdateDTO comment);
    Task<ServiceResponse<Comment>> DeleteComment(int id);
}