using Microsoft.EntityFrameworkCore;

public class PostRepository : IPostRepository
{
    private readonly MainContext _context;
    public PostRepository(MainContext context)
    {
        _context = context;
    }

    async Task<Post> IPostRepository.CreatePost(Post post)
    {
        await _context.Set<Post>().AddAsync(post);
        await _context.SaveChangesAsync();
        return post;
    }


    async Task<List<Post>> IPostRepository.GetAllPostByTitleId(int id)
    {
        var result = (from x in _context.Posts
                      where x.TitleId == id
                      select new Post
                      {
                          Content = x.Content,
                          DateTime = x.DateTime,
                          LikeCount = x.LikeCount,
                          UserId = x.UserId


                      }).ToListAsync<Post>();
        return await result;

    }

    async Task<List<Post>> IPostRepository.GetAllPostByTitleName(string name)
    {
        var result = (from x in _context.Posts
                      where x.Title.Name == name
                      select new Post
                      {
                          Content = x.Content,
                          DateTime = x.DateTime,
                          LikeCount = x.LikeCount,
                          UserId = x.UserId


                      }).ToListAsync<Post>();
        return await result;

    }

    async Task<List<Post>> IPostRepository.GetAllPosts()
    {
        return await _context.Set<Post>().ToListAsync();
    }

    async Task<List<Post>> IPostRepository.GetAllPostsOfUsersByUserId(int id)
    {
        var result = (from x in _context.Posts
                      where x.UserId == id
                      select new Post
                      {
                          Content = x.Content,
                          DateTime = x.DateTime,
                          LikeCount = x.LikeCount,
                          UserId = x.UserId


                      }).ToListAsync<Post>();
        return await result;
    }

    async Task<Post> IPostRepository.GetPostByPostId(int id)
    {
        return await _context.Set<Post>().FirstOrDefaultAsync(x => x.Id == id);
    }

    async public Task<Title> GetTitleById(int Id)
    {
        return await _context.Set<Title>().SingleOrDefaultAsync(x => x.Id == Id);
    }

    async Task<Post> IPostRepository.UpdatePost(Post post)
    {
        _context.Set<Post>().Update(post);
        await _context.SaveChangesAsync();
        return post;
    }
    async Task<Post> IPostRepository.DeletePost(Post post)
    {
        _context.Set<Post>().Remove(post);
        await _context.SaveChangesAsync();
        return post;
    }


    async Task<Title> IPostRepository.GetTitleByName(string Name)
    {
        return await _context.Set<Title>().FirstOrDefaultAsync(a => a.Name == Name);
    }

    async Task<User> IPostRepository.GetUserByUserId(int id)
    {
        return await _context.Set<User>().FirstOrDefaultAsync(x => x.Id == id);
    }

    async Task<Post> IPostRepository.UpdateLikeCountPost(Post post)
    {
        _context.Set<Post>().Update(post);
        await _context.SaveChangesAsync();
        return post;
    }
}