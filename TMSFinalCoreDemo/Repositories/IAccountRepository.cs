using Microsoft.AspNetCore.Identity;
using TMSFinalCoreDemo.Models;

namespace TMSFinalCoreDemo.Repositories
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(Login login);
    }
}
