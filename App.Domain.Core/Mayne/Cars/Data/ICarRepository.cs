using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Cars.Entities;


namespace App.Domain.Core.Mayne.Cars.Data
{
    public interface ICarRepository
    {
        Task<Car> Get(string plate , CancellationToken cancellation);
        Task<Result.Result> Add(Car car , CancellationToken cancellation);  
        Task<List<CarDto>> GetAll();
      //  Task<List<CarDto>> History(string plate , CancellationToken cancellation);

    }
}
