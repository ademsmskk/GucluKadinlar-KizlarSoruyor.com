public interface IUserService
{

    Task<ServiceResponse<List<User>>> GetAllUser();
    Task<ServiceResponse<User>> CreateUser(User User);
    Task<ServiceResponse<List<User>>>  GetUserByFirstnameAndLastname(string firstName, string lastName);
    Task<ServiceResponse<User>> GetUserByUserName(string userName);
    Task<ServiceResponse<User>> UpdateUserById(UserUpdateDTO User);

} 