public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    async public Task<ServiceResponse<Comment>> UpdateLikeCountComment(CommentUpdateDTO comment)
    {
        ServiceResponse<Comment> response = new ServiceResponse<Comment>();
        Comment updatedComment = await _commentRepository.GetCommentById(comment.Id);
        if (updatedComment != null)
        {

            updatedComment.LikeCount = comment.LikeCount + 1;
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _commentRepository.UpdateComment(updatedComment);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.CommentLikeUpdateOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Comment>> ICommentService.CreateComment(Comment comment)
    {
        ServiceResponse<Comment> response = new ServiceResponse<Comment>();
        try
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _commentRepository.CreateComment(comment);
            return response;

        }
        catch (System.Exception)
        {

            response.ResponseCode = ResponseCodeEnum.CommentCreateOperationFail;
            return response;
        }


    }

    async Task<ServiceResponse<Comment>> ICommentService.DeleteComment(int id)
    {
        ServiceResponse<Comment> response = new ServiceResponse<Comment>();

        Comment finder = await _commentRepository.GetCommentById(id);
        if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _commentRepository.DeleteComment(finder);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.CommentDeleteOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<List<Comment>>> ICommentService.GetAllCommentByPostId(int id)
    {
        ServiceResponse<List<Comment>> response = new ServiceResponse<List<Comment>>();
        try
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _commentRepository.GetAllCommentByPostId(id);
            return response;
        }
        catch (System.Exception)
        {

            response.ResponseCode = ResponseCodeEnum.CommentDeleteOperationFail;
            return response;
        }



    }

    async Task<ServiceResponse<Comment>> ICommentService.GetCommentById(int id)
    {
        ServiceResponse<Comment> response = new ServiceResponse<Comment>();

        Comment Commentfinderbyid = await _commentRepository.GetCommentById(id);

        if (Commentfinderbyid != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = Commentfinderbyid;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.GetCommentByIdOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Comment>> ICommentService.UpdateCommentById(CommentUpdateDTO comment)
    {
        ServiceResponse<Comment> response = new ServiceResponse<Comment>();
        Comment updatedComment = await _commentRepository.GetCommentById(comment.Id);
        if (updatedComment != null)
        {

            updatedComment.Content = comment.Content;
            response.ResponseCode = ResponseCodeEnum.CommentUpdateSuccess;
            response.Data = await _commentRepository.UpdateComment(updatedComment);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.CommentUpdateOperationFail;
            return response;
        }

    }
}