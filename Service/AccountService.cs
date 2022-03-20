using Microsoft.AspNetCore.Mvc;
[Serializable]
public class AccountService : IAccountService
{

    private IAccountRepository _accountRepository;

    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    async Task<ServiceResponse<List<Account>>> IAccountService.GetAllAccounts()
    {
        ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();

        try
        {
            response.Data = await _accountRepository.GetAllAccounts();
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllAccountOperationFail;
            return response;
        }
    }
    async Task<ServiceResponse<Account>> IAccountService.GetAccountByEmail(string email)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();
        var userfinderbyemail = await _accountRepository.GetAccountByEmail(email);


        if (userfinderbyemail != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetAccountByEmailOperationSuccess;
            response.Data = userfinderbyemail;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.GetAccountByEmailOperationFail;
            return response;
        }

    }



    async Task<ServiceResponse<Account>> IAccountService.UpdateAccountByEmail(AccountUpdateDTO account)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();

        var UpdateAccountByEmailFinder = await _accountRepository.GetAccountByEmail(account.Email);


        if (UpdateAccountByEmailFinder != null)
        {

            UpdateAccountByEmailFinder.Email = account.Email;
            UpdateAccountByEmailFinder.Password = account.Password;
            UpdateAccountByEmailFinder.IsBlocked = account.IsBlocked;
            UpdateAccountByEmailFinder.RoleId = account.RoleId;
            UpdateAccountByEmailFinder.Visibility = account.Visibility;
            response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailSuccess;
            response.Data = await _accountRepository.UpdateAccountByEmail(UpdateAccountByEmailFinder);
            return response;

        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailOperationFail;
            return response;
        }


    }

    async Task<ServiceResponse<Account>> IAccountService.UpdateAccountPassword(AccountUpdateDTO account, string OldPassword)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();
        Account finder = await _accountRepository.GetAccountByEmail(account.Email);

        if (finder != null && finder.Password == OldPassword)
        {
            finder.Password =account.Password;
            response.ResponseCode = ResponseCodeEnum.UpdateAccountPasswordSuccess;
            response.Data = await _accountRepository.UpdateAccountByEmail(finder);
            return response;
        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.UpdateAccountPasswordOperationFail;
            return response;
        }

    }


    async Task<ServiceResponse<Account>> IAccountService.BlockAccount(int id)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();


        Account finder = await _accountRepository.GetAccountById(id);

        try
        {

            if (finder != null)
            {
                finder.IsBlocked = !finder.IsBlocked;

                response.ResponseCode = ResponseCodeEnum.AccountBlockSuccess;
                response.Data = await _accountRepository.BlockAccount(finder);
                return response;

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.AccountBlockOperationFail;
                return response;
            }

        }
        catch (Exception ex)
        {
            response.ResponseCode = ResponseCodeEnum.AccountBlockOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Account>> IAccountService.ChangeRoleOfAccount(AccountUpdateDTO account)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();


        Account finder = await _accountRepository.GetAccountByEmail(account.Email);
        try
        {

            if (finder != null)
            {
                finder.RoleId = account.RoleId;

                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await _accountRepository.ChangeVisibilityOfAccount(finder);
                return response;

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.OperationFail;
                return response;
            }

        }
        catch (Exception ex)
        {
            response.ResponseCode = ResponseCodeEnum.OperationFail;
            return response;
        }



    }

    async Task<ServiceResponse<Account>> IAccountService.ChangeVisibilityOfAccount(int id)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();


        Account finder = await _accountRepository.GetAccountById(id);

        try
        {

            if (finder != null)
            {
                finder.Visibility = !finder.Visibility;

                response.ResponseCode = ResponseCodeEnum.ChangeVisibilityOfAccountSuccess;
                response.Data = await _accountRepository.ChangeVisibilityOfAccount(finder);
                return response;

            }
            else
            {
                response.ResponseCode = ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail;
                return response;
            }

        }
        catch (Exception ex)
        {
            response.ResponseCode = ResponseCodeEnum.ChangeVisibilityOfAccountOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Account>> IAccountService.CreateAccount(Account account)
    {
        ServiceResponse<Account> response = new ServiceResponse<Account>();

        var finder = _accountRepository.GetAccountByEmail(account.Email);
        if (finder == null)
        {
            response.ResponseCode = ResponseCodeEnum.AccountCreateSuccess;
            response.Data = await _accountRepository.CreateAccount(account);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.AccountCreateOperationFail;
            return response;
        }

    }



}