using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewProject.Api.Dtos;
using NewProject.Api.Services;

namespace NewProject.Api.Controllers;

[ApiController] // Faqat bitta bo'lsin
[Route("api/[controller]")] // Faqat bitta bo'lsin
public class CarsController : ControllerBase
{
    private readonly ICarService _service;

    public CarsController(ICarService carService)
    {
        _service = carService;
    }

    // 1. HAMMASINI OLISH (GET: api/Cars)
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAllCar());
    }

    // 2. ID BO'YICHA OLISH (GET: api/Cars/{id})
    [HttpGet("{id}")]
    public IActionResult GetById(Guid id)
    {
        var car = _service.GetCarById(id);
        if (car == null) return NotFound("Mashina topilmadi");
        return Ok(car);
    }

    // 3. YANGI QO'SHISH (POST: api/Cars)
    [HttpPost]
    public IActionResult Create([FromBody] CarCreateDto dto)
    {
        if (dto == null) return BadRequest("Ma'lumotlar bo'sh bo'lishi mumkin emas");
        var newId = _service.AddCar(dto);
        return Ok(newId);
    }

    // 4. TAHRIRLASH (PUT: api/Cars/{id})
    [HttpPut("{id}")]
    public IActionResult Update(Guid id, [FromBody] CarCreateDto dto)
    {
        var natija = _service.UpdateCar(id, dto);
        if (natija == false) return NotFound("O'zgartirish uchun mashina topilmadi");
        return Ok("Yangilandi");
    }

    // 5. O'CHIRISH (DELETE: api/Cars/{id})
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var natija = _service.DeleteCar(id);
        if (natija == false) return NotFound("O'chirish uchun mashina topilmadi");
        return Ok("O'chirildi");
    }
}