using MyMovie.Api.Dtos;

namespace MyMovie.Api.Services;

public interface IMovieService
{
    public Guid AddMovie(MovieCreateDto movieCreateDto);
    public bool DeleteMovie(Guid guid);
    public List<MovieGetDto> GetAllMovie();
    public MovieGetDto MovieGetById(Guid id);
    public bool UpdateMovie(Guid guid, MovieUpdateDto movieUpdateDto);
}