using CRUD.Api.Dtos;
using CRUD.Api.Entities;
using CRUD.Api.Persistence;

namespace CRUD.Api.Services
{
    public class AuthService : IAuthService
    {
        public string LoginUser(UserLoginDto userLoginDto)
        {
            foreach (var user in AppDBContext.Users)
            {
                if (user.UserName == userLoginDto.UserName
                    && user.Password == userLoginDto.Password)
                {
                    return user.UserId.ToString() + user.UserRole;
                }
            }

            return "User yoki parol xato";
        }

        public Guid RegisterUser(UserRegisterDto userRegisterDto)
        {
            var user = new User()
            {
                UserId = Guid.NewGuid(),
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                UserName = userRegisterDto.UserName,
                Password = userRegisterDto.Password,
                UserRole = "User",
                UserBlocked = false,
                RegisterTime = DateTime.Now
            };

            AppDBContext.Users.Add(user);

            return user.UserId;
        }
    }
}
