
namespace CRM.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- 1. Xizmatlarni qo'shish (Add services to the container) ---
            builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         // Bu property nomlarini C# da qanday bo'lsa, JSONda ham shunday qoldiradi (PascalCase)
         options.JsonSerializerOptions.PropertyNamingPolicy = null;
     }); 
            builder.Services.AddOpenApi();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // SHU YERDAN QO'SHASIZ:
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()   // Frontend saytingizga ruxsat beradi
                          .AllowAnyHeader()   // Sarlavhalarga ruxsat beradi
                          .AllowAnyMethod();  // Get, Post kabi metodlarga ruxsat beradi
                });
            });
            // -----------------------

            var app = builder.Build();

            // --- 2. Middleware (So'rovlar quvuri) ---
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // SHU YERGA HAM QO'SHASIZ (Tartib muhim: UseHttpsRedirection dan tepada tursin):
            app.UseCors();
            // -----------------------

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
