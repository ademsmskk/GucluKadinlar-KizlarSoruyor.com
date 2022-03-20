using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using System;
using System.Collections.Generic;

using System.Linq;



public class LoginService : ILoginService
{
    private readonly AppSettings _appSettings;
    private readonly IAccountRepository _accountRepository;

    public LoginService(IOptions<AppSettings> appSettings,IAccountRepository accountRepository )
    {
        _appSettings = appSettings.Value;
        this._accountRepository = accountRepository;
    }

    public LoginResponseDTO Authenticate(LoginDTO model)
    {
        var Account = _accountRepository.FindAccountByEmailAndPassword(model);
        if (Account == null) return null;
        var token = generateJwtToken(Account);

        return new LoginResponseDTO(token);
    }

   

    Account ILoginService.findAccountById(int id)
    {
         return _accountRepository.FindAccountById(id);
    }

    private string generateJwtToken(Account account)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim("id", account.Id.ToString()) }),
            Expires = DateTime.UtcNow.AddDays(15),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }

    
}

