namespace MyMovie.Api.Models;

public class Movie
{
    public Guid Id { get; set; } // Har bir kino uchun unikal ID
    public string Title { get; set; } 
    public string Genre { get; set; } 
    public int Year { get; set; }
    public double Rating { get; set; }
    public string PosterPath { get; set; }  // Serverdagi rasm manzili (masalan: "/posters/rasm.jpg")
}
