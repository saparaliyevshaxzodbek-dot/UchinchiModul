using CRUD.Api.Dtos;

namespace CRUD.Api.Services;

public interface IAuthService
{
    public Guid RegisterUser(UserRegisterDto userRegisterDto);
    public string LoginUser(UserLoginDto userLoginDto);
}