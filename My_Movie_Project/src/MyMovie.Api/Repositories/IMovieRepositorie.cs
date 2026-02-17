using MyMovie.Api.Models;

namespace MyMovie.Api.Repositories;

public interface IMovieRepositorie
{
    // Barcha kinolarni fayldan o'qib, List ko'rinishida qaytarish
    List<Movie> GetAll();

    // Berilgan kinolar ro'yxatini faylga JSON qilib saqlash
    void Save(List<Movie> movies);
}