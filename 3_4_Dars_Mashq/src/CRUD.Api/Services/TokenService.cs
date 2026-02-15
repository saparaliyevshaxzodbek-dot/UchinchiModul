namespace CRUD.Api.Services;

public class TokenService : ITokenService
{

    public  (string userId, string role) GetTokenInfo(string token)
    {
        var userId = token.Substring(0, 36);
        var role = token.Substring(36);

        return (userId, role);
    }
}
