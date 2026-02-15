namespace NewProject.Api.Models;

public class Car
{
    public Guid Id { get; set; }           // Har bir e'lonning takrorlanmas raqami
    public string Brand { get; set; }     // Masalan: Chevrolet, BMW, Mercedes
    public string Model { get; set; }     // Masalan: Malibu, X5, S-Class
    public int Year { get; set; }          // Ishlab chiqarilgan yili (masalan: 2023)
    public decimal Price { get; set; }     // Narxi (decimal - pul birliklari uchun eng to'g'ri tur)
    public string ImageUrl { get; set; }   // Rasm manzili (hozircha link, keyin fayl qilamiz)
    public string Color { get; set; }      // Rangi (masalan: Qora, Oq, Metallik)
    public DateTime CreatedAt { get; set; } = DateTime.Now; // E'lon berilgan vaqt
}
