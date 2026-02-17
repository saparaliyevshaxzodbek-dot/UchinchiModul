
using MyMovie.Api.Services;

namespace MyMovie.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1. CORS sozlamasi (Frontend bog'lanishi uchun shart!)
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyOrigin()   // Hamma joydan kelgan so'rovga ruxsat
                          .AllowAnyMethod()   // GET, POST, PUT, DELETE - hammasiga ruxsat
                          .AllowAnyHeader();  // Har qanday headerlarga ruxsat
                });
            });

            // 2. Controllerlarni qo'shish
            builder.Services.AddControllers();

            // 3. Swagger sozlamalari
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // 4. Sening Servislaringni ro'yxatdan o'tkazamiz
            // Biz Service ichida 'new MovieRepositorie()' qilganimiz uchun faqat Service'ni o'zini qo'shsak yetadi
            builder.Services.AddScoped<IMovieService, MovieService>();

            var app = builder.Build();

            // 5. Swagger'ni yoqish
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // 6. Frontend bog'lanishi uchun CORS'ni ishga tushiramiz
            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            // 7. MUHIM: wwwroot ichidagi rasmlar (posters) brauzerda ochilishi uchun
            app.UseStaticFiles();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
