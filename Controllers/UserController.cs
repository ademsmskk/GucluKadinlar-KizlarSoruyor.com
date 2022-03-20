using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _UserService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public UserController(IUserService UserService)
    {
        _UserService = UserService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<User>>>> GetAllUser()
    {
        return await _UserService.GetAllUser();
    }

    [HttpGet("username")]
    public async Task<ActionResult<ServiceResponse<User>>> GetUserByUserName(string userName)
    {
        return await _UserService.GetUserByUserName(userName);
    }


    
    
    [HttpGet("User")]
    public async Task<ActionResult<ServiceResponse<List<User>>>> GetUserByFirstnameAndLastname(string firstName, string lastName)
    {
        return await _UserService.GetUserByFirstnameAndLastname(firstName, lastName);
    }


    [HttpPost]
    public async Task<ActionResult<ServiceResponse<User>>> CreateUser(User User)
    {
        return await _UserService.CreateUser(User);
    }



    [HttpPut("update")]
    public async Task<ActionResult<ServiceResponse<User>>> UpdateUserById(UserUpdateDTO User)
    {
        return await _UserService.UpdateUserById( User);

    }
 





}