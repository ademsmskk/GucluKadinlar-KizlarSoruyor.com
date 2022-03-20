using Microsoft.EntityFrameworkCore;
using System.Linq;


public class AccountRepository : IAccountRepository
{

    private readonly MainContext _context;
    public AccountRepository(MainContext context)
    {
        _context = context;

    }
    public Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
    {
        var accountFinded = (from x in _context.Accounts
                             where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                             select x).FirstOrDefault();
        return accountFinded;
    }

    Account IAccountRepository.FindAccountById(int id)
    {
        var accountByID = (from x in _context.Accounts
                           where x.Id == id
                           select x).FirstOrDefault();
        return accountByID;

    }

    async Task<List<Account>> IAccountRepository.GetAllAccounts()
    {
        return await _context.Accounts.ToListAsync();
    }

    async Task<Account> IAccountRepository.CreateAccount(Account account)
    {
        await _context.Set<Account>().AddAsync(account);
        await _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.GetAccountByEmail(string email)
    {
        return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);
    }


    async Task<Account> IAccountRepository.UpdateAccountByEmail(Account account)
    {
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.UpdateAccountPassword(Account account)
    {

        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.ChangeVisibilityOfAccount(Account account)
    {
        account.Visibility = !account.Visibility;
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.BlockAccount(Account account)
    {

        _context.Set<Account>().Update(account);
        await _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.ChangeRoleOfAccount(Account account)
    {
        _context.Set<Account>().Update(account);
        _context.SaveChangesAsync();
        return account;
    }

    async Task<Account> IAccountRepository.GetAccountById(int id)
    {
        return await _context.Set<Account>().FirstOrDefaultAsync(x => x.Id == id);
    }
}
