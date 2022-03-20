using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]


public class AccountController : ControllerBase
{
    private readonly IAccountService _accountService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public AccountController(IAccountService accountService)
    {
        _accountService = accountService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }
    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Account>>>> GetAllAccounts()
    {
        return await _accountService.GetAllAccounts();
    }


    [HttpGet("GetAccountByEmail")]
    public async Task<ActionResult<ServiceResponse<Account>>> GetAccountByEmail(string email)
    {
        return await _accountService.GetAccountByEmail(email);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Account>>> CreateAccount(Account account)
    {
        return await _accountService.CreateAccount(account);
    }

    [HttpPut("UpdateAccountByEmail")]
    public async Task<ActionResult<ServiceResponse<Account>>> UpdateAccountByEmail(AccountUpdateDTO account)
    {
        return await _accountService.UpdateAccountByEmail(account);

    }


    [HttpPut("UpdateAccountPassword")]
    public async Task<ActionResult<ServiceResponse<Account>>> UpdateAccountPassword(AccountUpdateDTO account, string OldPassword)
    {
        return await _accountService.UpdateAccountPassword(account, OldPassword);
    }

    [HttpPut("Visibility")]
    public async Task<ActionResult<ServiceResponse<Account>>> ChangeVisibilityOfAccount(int id)
    {
        return await _accountService.ChangeVisibilityOfAccount(id);
    }
    [HttpPut("Block")]
    public async Task<ActionResult<ServiceResponse<Account>>> BlockAccount(int id)
    {
        return await _accountService.BlockAccount(id);
    }
    [HttpPut("Role")]
    public async Task<ActionResult<ServiceResponse<Account>>> ChangeRoleOfAccount(AccountUpdateDTO account)
    {
        return await _accountService.ChangeRoleOfAccount(account);
    }
}






