using MyMovie.Api.Models;
using System.Text.Json;

namespace MyMovie.Api.Repositories;

public class MovieRepositorie : IMovieRepositorie
{
    private readonly string _filePath;

    public MovieRepositorie()
    {
        // 1. Loyiha ishlayotgan joydan 'Data' papkasini manzilini olish
        var directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        // 2. Agar 'Data' papkasi bo'lmasa, uni yaratish
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        // 3. 'movies.json' faylini manzilini belgilash
        _filePath = Path.Combine(directoryPath, "movies.json");

        // 4. Agar fayl bo'lmasa, bo'sh fayl yaratish
        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]"); // Bo'sh JSON massivini yozib qo'yamiz
        }
    }

    // FAYLDAN O'QISH (Deserialization)
    public List<Movie> GetAll()
    {
        var json = File.ReadAllText(_filePath);

        // Agar fayl bo'sh bo'lsa yoki xato bo'lsa, yangi List qaytaramiz
        return JsonSerializer.Deserialize<List<Movie>>(json) ?? new List<Movie>();
    }

    // FAYLGA SAQLASH (Serialization)
    public void Save(List<Movie> movies)
    {
        // JSONni chiroyli ko'rinishda (indentation) saqlaymiz
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(movies, options);

        File.WriteAllText(_filePath, json);
    }
}
