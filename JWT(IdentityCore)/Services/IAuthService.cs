using JWT_IdentityCore_.Model;

namespace JWT_IdentityCore_.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginUser user);
        Task<bool> Login(LoginUser user);
        string GenerateTokenString(LoginUser user);
    }
}