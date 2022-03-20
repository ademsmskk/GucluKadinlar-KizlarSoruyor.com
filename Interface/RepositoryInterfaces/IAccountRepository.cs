public interface IAccountRepository
{

    Task<List<Account>> GetAllAccounts();
    Task<Account> CreateAccount(Account account);
    Task<Account> GetAccountByEmail(string email);
    Task<Account> GetAccountById(int id);
    Task<Account> UpdateAccountByEmail( Account account); 
    Task<Account> UpdateAccountPassword(Account account); 
    Task<Account> ChangeVisibilityOfAccount(Account account);
    Task<Account> BlockAccount(Account account);
    Task<Account> ChangeRoleOfAccount(Account account);
    Account FindAccountByEmailAndPassword(LoginDTO loginDTO);
    Account FindAccountById(int id);

}

