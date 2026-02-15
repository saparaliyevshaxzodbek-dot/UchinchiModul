using NewProject.Api.Dtos;
using NewProject.Api.Models;

namespace NewProject.Api.Services;

public interface ICarService
{
    public Guid AddCar(CarCreateDto carCreateDto);
    public bool DeleteCar(Guid carId);
    public Car? GetCarById(Guid carId);
    public List<Car> GetAllCar();
    public bool UpdateCar(Guid guid, CarCreateDto carCreateDto);

}