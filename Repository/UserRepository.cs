using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository
{
    private readonly MainContext _context;

    public UserRepository(MainContext context)
    {
        _context = context;
    }

    async Task<User> IUserRepository.CreateUser(User user)
    {
        await _context.Set<User>().AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    async Task<List<User>> IUserRepository.GetAllUsers()
    {
        return await _context.Set<User>().ToListAsync();
    }

    async Task<List<User>> IUserRepository.GetUserByFirstnameAndLastname(string firstName, string lastName)
    {
        return await _context.Set<User>().Where(x => x.FirstName == firstName && x.LastName == lastName).ToListAsync();
    }

   async Task<User> IUserRepository.GetUserByUserId(int id)
    {
       return await _context.Set<User>().FirstOrDefaultAsync(x=>x.Id==id);
    }

    async Task<User> IUserRepository.GetUserByUserName(string userName)
    {
        return await _context.Set<User>().FirstOrDefaultAsync(x => x.Username == userName);
    }

    async Task<User> IUserRepository.UpdateUser(User user)
    {
        _context.Set<User>().Update(user);
        await _context.SaveChangesAsync();
        return user;
    }


}