using CRM.Api.Data;
using CRM.Api.Dtos;
using CRM.Api.Models;

namespace CRM.Api.Services;

public class UserService : IUserService
{
    private readonly UserData _userData;
    private readonly UserCreateDto UserCreateDto;

    // KONSTRUKTOR: Bazani (faylni) shu yerda jonlantiramiz
    public UserService()
    {
        _userData = new UserData();
        UserCreateDto = new UserCreateDto();
    }

    // 1. Foydalanuvchi qo'shish (DTO -> User o'tkazish)
    public Guid AddUser(UserCreateDto userCreatedDto)
    {
        List<User> users = _userData.GetAllUsers() ?? new List<User>();

        // MUHIM: DTO-dan Modelga o'tkazamiz
        User newUser = new User();
        newUser.Id = Guid.NewGuid();
        newUser.Name = userCreatedDto.Name;
        // newUser.Company = userCreatedDto.Company; // Agar modelingizda bo'lsa

        users.Add(newUser);
        _userData.SaveAllUsers(users);

        return newUser.Id;
    }

    // 2. Hammani olish (User -> DTO o'tkazish)
    public List<UserGetDto> GetAllUsers()
    {
        List<User> users = _userData.GetAllUsers() ?? new List<User>();
        List<UserGetDto> resultDtos = new List<UserGetDto>();

        foreach (var user in users)
        {
            UserGetDto dto = new UserGetDto();
            dto.Name = user.Name;
            dto.Company = "Noma'lum"; // Rasmingizdagi UserGetDto-ga moslab
            resultDtos.Add(dto);
        }

        return resultDtos;
    }

    // 3. ID orqali olish
    public UserGetDto GetUserById(Guid userId)
    {
        List<User> users = _userData.GetAllUsers() ?? new List<User>();

        foreach (var user in users)
        {
            if (user.Id == userId)
            {
                UserGetDto dto = new UserGetDto();
                dto.Name = user.Name;
                return dto;
            }
        }
        return null!;
    }

    // 4. O'chirish
    public bool DeleteUser(Guid userId)
    {
        List<User> users = _userData.GetAllUsers() ?? new List<User>();

        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Id == userId)
            {
                users.RemoveAt(i);
                _userData.SaveAllUsers(users);
                return true;
            }
        }
        return false;
    }

    // 5. Yangilash
    public bool UpdateUser(Guid guid, UserUpdateDto userUpdateDto)
    {
        List<User> users = _userData.GetAllUsers() ?? new List<User>();

        foreach (var user in users)
        {
            if (user.Id == guid)
            {
                user.Name = userUpdateDto.Name;
                _userData.SaveAllUsers(users);
                return true;
            }
        }
        return false;
    }

    public void AddUser(User newUser)
    {
        throw new NotImplementedException();
    }
}