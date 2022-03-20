public interface IUserRepository
{

    Task<List<User>> GetAllUsers();
    Task<User> CreateUser(User User);
    Task<List<User>> GetUserByFirstnameAndLastname(string firstName, string lastName);
    Task<User> GetUserByUserName(string userName);
    Task<User> GetUserByUserId(int id);
    Task<User> UpdateUser(User User);



}