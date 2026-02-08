using CRUD.Api.Repositories;

namespace CRUD.Api.Services;

public class TokenService : ITokenService
{
    private readonly IUserRepository UserRepository;

    public TokenService()
    {
        UserRepository = new UserRepository();
    }
    public (string userId, string role) GetTokenInfo(string token)
    {
        var userId = token.Substring(0, 26);
        var role = token.Substring(26);
        return (userId, role);
    }
}
