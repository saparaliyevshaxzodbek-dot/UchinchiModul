
using NewProject.Api.Services;

namespace NewProject.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // CarService-ni Singleton sifatida ro'yxatdan o'tkazamiz
            builder.Services.AddSingleton<ICarService, CarService>();

            builder.Services.AddCors(); // CORS-ni qo'shish

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // 1. Birinchi navbatda CORS ni ishga tushiramiz
            app.UseCors(policy => policy
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // 2. Keyin qolganlarini
            app.UseRouting(); // Buni qo'shib qo'yish foydali
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();

        }
    }
}
