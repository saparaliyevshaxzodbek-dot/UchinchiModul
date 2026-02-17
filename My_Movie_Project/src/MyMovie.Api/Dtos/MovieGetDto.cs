namespace MyMovie.Api.Dtos;

public class MovieGetDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } 
    public string Genre { get; set; } 
    public int Year { get; set; }
    public double Rating { get; set; }
    public string PosterUrl { get; set; } // Brauzer rasmni topishi uchun tayyor link
}