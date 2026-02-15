using CRM.Api.Models;
using System.Text.Json;


namespace CRM.Api.Data;

public class UserData : IUserData
{
    private const string FileName = "users.json";

    // 1. HAMMA FOYDALANUVCHILARNI O'QISH
    public List<User>? GetAllUsers()
    {
        // Agar fayl hali yaratilmagan bo'lsa, xato bermasligi uchun bo'sh list qaytaramiz
        if (!File.Exists(FileName))
        {
            return new List<User>();
        }

        try
        {
            // Faylni ichidagi hamma matnni o'qiymiz
            string jsonString = File.ReadAllText(FileName);

            // Matn ko'rinishidagi JSONni C# List (obyekt) holatiga keltiramiz
            return JsonSerializer.Deserialize<List<User>>(jsonString);
        }
        catch (Exception)
        {
            // Agar faylni o'qishda xato bo'lsa (masalan fayl buzilgan bo'lsa)
            return new List<User>();
        }
    }

    // 2. MA'LUMOTLARNI FAYLGA SAQLASH
    public void SaveAllUsers(List<User> users)
    {
        // JSON fayl chiroyli ko'rinishi (indentation) uchun sozlama
        var options = new JsonSerializerOptions { WriteIndented = true };

        // C# Listni matn (string) ko'rinishiga o'tkazamiz
        string jsonString = JsonSerializer.Serialize(users, options);

        // Tayyor matnni faylga yozib qo'yamiz (fayl bo'lsa ustidan yozadi, bo'lmasa yaratadi)
        File.WriteAllText(FileName, jsonString);
    }

    // 3. FOYDALANUVCHI BORLIGINI TEKSHIRISH
    public bool UserExists(Guid userId)
    {
        // 1. Avval hamma foydalanuvchilarni fayldan o'qib olamiz
        List<User>? allUsers = GetAllUsers();

        // 2. Agar ro'yxat bo'sh bo'lsa, demak foydalanuvchi ham yo'q
        if (allUsers == null)
        {
            return false;
        }

        // 3. Har bir foydalanuvchini bittadan tekshirib chiqamiz (foreach tsikli)
        foreach (var user in allUsers)
        {
            // Agar foydalanuvchining ID-si biz qidirayotgan ID-ga teng bo'lsa
            if (user.UserId == userId)
            {
                return true; // Topildi! Funktsiyani shu yerda to'xtatib, true qaytaramiz
            }
        }

        // 4. Agar sikl tugaguncha hech kim topilmasa, false qaytaramiz
        return false;
    }
}
