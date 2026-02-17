using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyMovie.Api.Dtos;
using MyMovie.Api.Services;

namespace MyMovie.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    private readonly IMovieService _movieService;

    // Konstruktorda serviceni qabul qilamiz
    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    // 1. YANGI KINO QO'SHISH (POST)
    [HttpPost("add")]
    public IActionResult AddMovie([FromForm] MovieCreateDto dto)
    {
        // [FromForm] - chunki biz rasm faylini yuboramiz
        var id = _movieService.AddMovie(dto);
        return Ok(new { Message = "Kino muvaffaqiyatli qo'shildi", Id = id });
    }

    // 2. BARCHA KINOLARNI OLISH (GET)
    [HttpGet("get-all")]
    public IActionResult GetAll()
    {
        var movies = _movieService.GetAllMovie();
        return Ok(movies);
    }

    // 3. BITTA KINONI ID BO'YICHA OLISH (GET)
    [HttpGet("get/{id}")]
    public IActionResult GetById(Guid id)
    {
        var movie = _movieService.MovieGetById(id);

        if (movie == null)
            return NotFound("Kino topilmadi");

        return Ok(movie);
    }

    // 4. KINONI TAHRIRLASH (PUT)
    [HttpPut("update/{id}")]
    public IActionResult Update(Guid id, [FromForm] MovieUpdateDto dto)
    {
        var result = _movieService.UpdateMovie(id, dto);

        if (result == false)
            return NotFound("O'zgartirishda xatolik: Kino topilmadi");

        return Ok("Ma'lumotlar yangilandi");
    }

    // 5. KINONI O'CHIRISH (DELETE)
    [HttpDelete("delete/{id}")]
    public IActionResult Delete(Guid id)
    {
        var result = _movieService.DeleteMovie(id);

        if (result == false)
            return NotFound("O'chirishda xatolik: Kino topilmadi");

        return Ok("Kino va uning posteri o'chirildi");
    }
}