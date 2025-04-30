using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Result;


namespace App.Domain.AppService.Mayne.Car
{
    public interface ICarAppService
    {
        Task<Result> AddCar(CarDto carDto, CancellationToken cancellation);
        Task<Result> DeleteCar(int id, CancellationToken cancellation);
        Task<CarDto> GetCar(int id, CancellationToken cancellation);
        Task<List<CarDto>> GetCars(CancellationToken cancellation);
        Task<Result> UpdateCar(CarDto carDto, CancellationToken cancellation);
    }
}
