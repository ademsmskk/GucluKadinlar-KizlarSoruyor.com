public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    async Task<ServiceResponse<User>> IUserService.CreateUser(User User)
    {
        ServiceResponse<User> response = new ServiceResponse<User>();

        User finder = await _userRepository.GetUserByUserName(User.Username);
        if (finder == null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _userRepository.CreateUser(User);
            return response;
        }
        else if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.DuplicateUserError;
            return response;
        }
        else
        {

            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<List<User>>> IUserService.GetAllUser()
    {
        ServiceResponse<List<User>> response = new ServiceResponse<List<User>>();

        try
        {
            response.Data = await _userRepository.GetAllUsers();
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<List<User>>> IUserService.GetUserByFirstnameAndLastname(string firstName, string lastName)
    {
        ServiceResponse<List<User>> response = new ServiceResponse<List<User>>();
        List<User> userfinder = await _userRepository.GetUserByFirstnameAndLastname(firstName, lastName);

        if (userfinder != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = userfinder;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }
    }

  async  Task<ServiceResponse<User>> IUserService.GetUserByUserName(string userName)
    {
        ServiceResponse<User> response = new ServiceResponse<User>();
        User userfinderbyname = await _userRepository.GetUserByUserName(userName);


        if (userfinderbyname != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = userfinderbyname;
            return response;
        }
        else if (userfinderbyname==null)
        {
             response.ResponseCode = ResponseCodeEnum.GetUserByUserNameFail;
            response.Data = userfinderbyname;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }
    }

   async Task<ServiceResponse<User>> IUserService.UpdateUserById(UserUpdateDTO User)
    {
        ServiceResponse<User> response = new ServiceResponse<User>();
        var updatedUser = await _userRepository.GetUserByUserId(User.Id);
        if (updatedUser != null)
        {

            updatedUser.FirstName = User.FirstName;
            updatedUser.LastName = User.LastName;
            updatedUser.PhoneNumber= User.PhoneNumber;
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _userRepository.UpdateUser(updatedUser);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.UserUpdateOperationFail;
            return response;
        }

    }
}