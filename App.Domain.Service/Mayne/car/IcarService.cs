using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.Result;


namespace App.Domain.Service.Mayne.car
{
    public interface IcarService
    {
        Task<Result> Get(string plate, CancellationToken cancellation);
        Task<Result> Add(Car car, CancellationToken cancellation);
        Task<List<CarDto>> GetAll();
        Task<List<CarDto>> History(string plate, CancellationToken cancellation);
    }
}
