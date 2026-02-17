using MyMovie.Api.Dtos;
using MyMovie.Api.Models;
using MyMovie.Api.Repositories;

namespace MyMovie.Api.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepositorie MovieRepository;
    private readonly IWebHostEnvironment _env;

    // Konstruktorda obyektni o'zimiz yaratib olamiz (Ustozingiz kabi)
    public MovieService(IWebHostEnvironment env)
    {
        MovieRepository = new MovieRepositorie(); // Repositoryni to'g'ridan-to'g'ri yaratdik
        _env = env;
    }

    // 1. KINO QO'SHISH
    public Guid AddMovie(MovieCreateDto movieCreateDto)
    {
        // Rasmni saqlash qismi (buni soddalashtirib bo'lmaydi, rasm papkaga tushishi shart)
        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(movieCreateDto.PosterFile.FileName);
        string folderPath = Path.Combine(_env.WebRootPath, "posters");
        string fullPath = Path.Combine(folderPath, fileName);

        using (var stream = new FileStream(fullPath, FileMode.Create))
        {
            movieCreateDto.PosterFile.CopyTo(stream);
        }

        // Yangi kino obyekti
        var movie = new Movie()
        {
            Id = Guid.NewGuid(),
            Title = movieCreateDto.Title,
            Genre = movieCreateDto.Genre,
            Year = movieCreateDto.Year,
            Rating = movieCreateDto.Rating,
            PosterPath = "/posters/" + fileName
        };

        // Repositorydan hamma kinolarni olamiz, yangisini qo'shib, saqlaymiz
        var allMovies = MovieRepository.GetAll();
        allMovies.Add(movie);
        MovieRepository.Save(allMovies);

        return movie.Id;
    }

    // 2. BARCHA KINOLARNI OLISH
    public List<MovieGetDto> GetAllMovie()
    {
        var movies = MovieRepository.GetAll();
        var movieGetDtos = new List<MovieGetDto>();

        // LINQ ishlatmasdan, oddiy foreach bilan DTOga o'giramiz
        foreach (var movie in movies)
        {
            var dto = new MovieGetDto()
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre,
                Year = movie.Year,
                Rating = movie.Rating,
                PosterUrl = movie.PosterPath
            };
            movieGetDtos.Add(dto);
        }

        return movieGetDtos;
    }

    // 3. KINONI O'CHIRISH
    public bool DeleteMovie(Guid guid)
    {
        var movies = MovieRepository.GetAll();

        foreach (var movie in movies)
        {
            if (movie.Id == guid)
            {
                // Avval rasmini o'chirib tashlaymiz
                string rasmYoli = Path.Combine(_env.WebRootPath, movie.PosterPath.TrimStart('/'));
                if (File.Exists(rasmYoli))
                {
                    File.Delete(rasmYoli);
                }

                // Ro'yxatdan o'chirib saqlaymiz
                movies.Remove(movie);
                MovieRepository.Save(movies);
                return true;
            }
        }

        return false;
    }

    // 4. ID BO'YICHA TOPISH
    public MovieGetDto MovieGetById(Guid movieId)
    {
        var movies = MovieRepository.GetAll();

        foreach (var movie in movies)
        {
            if (movie.Id == movieId)
            {
                var dto = new MovieGetDto()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Genre = movie.Genre,
                    Year = movie.Year,
                    Rating = movie.Rating,
                    PosterUrl = movie.PosterPath
                };
                return dto;
            }
        }

        return null; // Topilmasa null qaytadi
    }

    // 5. TAHRIRLASH (Update)
    public bool UpdateMovie(Guid guid, MovieUpdateDto movieUpdateDto)
    {
        var movies = MovieRepository.GetAll();

        foreach (var movie in movies)
        {
            if (movie.Id == guid)
            {
                movie.Title = movieUpdateDto.Title;
                movie.Genre = movieUpdateDto.Genre;
                movie.Year = movieUpdateDto.Year;
                movie.Rating = movieUpdateDto.Rating;

                // Agar yangi rasm yuklagan bo'lsa
                if (movieUpdateDto.PosterFile != null)
                {
                    // Eski rasmni o'chirib, yangisini saqlash mantiqi shu yerga tushadi
                }

                MovieRepository.Save(movies);
                return true;
            }
        }

        return false;
    }

        
}


    