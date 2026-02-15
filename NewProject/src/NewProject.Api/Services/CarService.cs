using NewProject.Api.Dtos;
using NewProject.Api.Models;

namespace NewProject.Api.Services;

public class CarService : ICarService
{
    // Static list ma'lumotni xotirada saqlash uchun
    private static List<Car> Cars = new List<Car>();

    // BO'SH KONSTRUKTOR ALBATTA BO'LSIN!
    public CarService()
    {
    }
    public Guid AddCar(CarCreateDto carCreateDto)
    {
        var car = new Car
        {
            Id = Guid.NewGuid(),
            Brand = carCreateDto.Brand,
            Model = carCreateDto.Model,
            Price = carCreateDto.Price,
            Year = carCreateDto.Year,
            ImageUrl = carCreateDto.ImageUrl,
            Color = carCreateDto.Color
        };
        Cars.Add(car);
        return car.Id;
    }
    public bool DeleteCar(Guid carId)
    {
        for (int i = Cars.Count - 1; i >= 0; i--)
        {
            if (Cars[i].Id == carId)
            {
                Cars.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public List<Car> GetAllCar()
    {
        return Cars;
    }

    public Car? GetCarById(Guid carId)
    {
        foreach (var car in Cars)
        {
            if (car.Id == carId)
            {
                return car;
            }
        }
        return null;
    }



    public bool UpdateCar(Guid guid, CarCreateDto carCreateDto)
    {
        var car = GetCarById(guid);
        if (car == null) return false;

        car.Brand = carCreateDto.Brand;
        car.Model = carCreateDto.Model;
        car.Price = carCreateDto.Price;
        car.Year = carCreateDto.Year;
        car.ImageUrl = carCreateDto.ImageUrl;
        car.Color = carCreateDto.Color;

        return true;
    }

}
