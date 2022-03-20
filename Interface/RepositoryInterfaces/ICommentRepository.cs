public interface ICommentRepository
{

    Task<List<Comment>> GetAllCommentByPostId(int id);
    Task<Comment> CreateComment(Comment comment);
    Task<Comment> GetCommentById(int id);
    Task<Comment> UpdateComment(Comment comment);
    Task<Comment> DeleteComment(Comment comment);
     Task<Comment> UpdateLikeCountComment(Comment comment);



}