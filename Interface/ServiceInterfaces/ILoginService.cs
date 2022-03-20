public interface ILoginService
{   
     LoginResponseDTO Authenticate(LoginDTO model);
    Account findAccountById(int id);
}