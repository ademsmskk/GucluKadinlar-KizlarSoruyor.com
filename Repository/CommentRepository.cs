using Microsoft.EntityFrameworkCore;

public class CommentRepository : ICommentRepository
{
    private readonly MainContext _context;
    public CommentRepository(MainContext context)
    {
        _context = context;
    }

   async public Task<Comment> UpdateLikeCountComment(Comment comment)
    {
         _context.Set<Comment>().Update(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    async Task<Comment> ICommentRepository.CreateComment(Comment comment)
    {
        await _context.Set<Comment>().AddAsync(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    async Task<Comment> ICommentRepository.DeleteComment(Comment comment)
    {
        _context.Set<Comment>().Remove(comment);
        await _context.SaveChangesAsync();
        return comment;
    }

    async Task<List<Comment>> ICommentRepository.GetAllCommentByPostId(int id)
    {
        return await _context.Set<Comment>().Where(x => x.PostId == id).ToListAsync();
    }

    async Task<Comment> ICommentRepository.GetCommentById(int id)
    {
        return await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);
    }

    async Task<Comment> ICommentRepository.UpdateComment(Comment comment)
    {
        _context.Set<Comment>().Update(comment);
        await _context.SaveChangesAsync();
        return comment;
    }
}