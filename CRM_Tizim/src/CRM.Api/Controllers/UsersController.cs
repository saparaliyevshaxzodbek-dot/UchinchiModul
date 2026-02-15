using CRM.Api.Dtos;
using CRM.Api.Models;
using CRM.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserService _userService;
    private readonly UserCreateDto UserCreateDto;

    public UsersController()
    {
        // Siz aytgan "eskicha" jonlantirish usuli
        _userService = new UserService();
        UserCreateDto = new UserCreateDto();
    }

    // 1. Yangi foydalanuvchi yaratish/qo'shish
    // Manzil: api/users/add
    [HttpPost("add")]
    public IActionResult Create(UserCreateDto dto)
    {
        var id = _userService.AddUser(dto);
        return Ok(new { Action = "Add / Create", Message = "Foydalanuvchi bazaga qo'shildi", Id = id });
    }

    // 2. Barcha foydalanuvchilarni ro'yxatini olish
    // Manzil: api/users/get-all
    [HttpGet("get-all")]
    public IActionResult GetAll()
    {
        var users = _userService.GetAllUsers();
        return Ok(new { Action = "Get All / Read", Data = users });
    }

    // 3. ID bo'yicha bitta foydalanuvchini topish
    // Manzil: api/users/get-by-id/{id}
    [HttpGet("get-by-id/{id}")]
    public IActionResult GetById(Guid id)
    {
        var user = _userService.GetUserById(id);
        if (user == null)
            return NotFound(new { Action = "GetById", Status = "Topilmadi" });

        return Ok(new { Action = "Get By Id", Data = user });
    }

    // 4. Foydalanuvchini o'chirib tashlash
    // Manzil: api/users/delete/{id}
    [HttpDelete("delete/{id}")]
    public IActionResult Delete(Guid id)
    {
        var result = _userService.DeleteUser(id);
        if (result)
            return Ok(new { Action = "Delete / Remove", Message = "Foydalanuvchi o'chirildi" });

        return NotFound(new { Action = "Delete", Status = "ID topilmadi" });
    }

    // 5. Foydalanuvchi ma'lumotlarini yangilash/tahrirlash
    // Manzil: api/users/update/{id}
    [HttpPut("update/{id}")]
    public IActionResult Update(Guid id, UserUpdateDto dto)
    {
        var result = _userService.UpdateUser(id, dto);
        if (result)
            return Ok(new { Action = "Update / Edit", Message = "Ma'lumotlar tahrirlandi" });

        return NotFound(new { Action = "Update", Status = "ID topilmadi" });
    }

}