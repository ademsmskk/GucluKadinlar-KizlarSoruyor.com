public interface IAccountService
{

    Task<ServiceResponse<List<Account>>> GetAllAccounts();
    Task<ServiceResponse<Account>> CreateAccount(Account account);
    Task<ServiceResponse<Account>> GetAccountByEmail(string email);
    Task<ServiceResponse<Account>> UpdateAccountByEmail(AccountUpdateDTO account);
    Task<ServiceResponse<Account>> UpdateAccountPassword(AccountUpdateDTO account,string OldPassword);
    Task<ServiceResponse<Account>>  ChangeVisibilityOfAccount(int id);
    Task<ServiceResponse<Account>> BlockAccount(int id);
    Task<ServiceResponse<Account>> ChangeRoleOfAccount(AccountUpdateDTO account);

}