namespace MyMovie.Api.Dtos;

public class MovieCreateDto
{
    public string Title { get; set; } 
    public string Genre { get; set; } 
    public int Year { get; set; }
    public double Rating { get; set; }

    // Foydalanuvchi kompyuteridan tanlagan haqiqiy fayl
    public IFormFile PosterFile { get; set; }
}
