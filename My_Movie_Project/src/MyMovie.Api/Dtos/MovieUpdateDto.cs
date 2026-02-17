namespace MyMovie.Api.Dtos;

public class MovieUpdateDto
{
    public Guid Id { get; set; } // Qaysi kinoni tahrirlashni bilish uchun
    public string Title { get; set; } 
    public string Genre { get; set; } 
    public int Year { get; set; }
    public double Rating { get; set; }

    // Ixtiyoriy: rasm o'zgarmasa null kelishi mumkin
    public IFormFile? PosterFile { get; set; }
}