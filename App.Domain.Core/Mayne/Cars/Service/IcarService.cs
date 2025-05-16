using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.Result;


namespace App.Domain.Core.Mayne.Cars.Service
{
	public interface IcarService
	{
		Task<Car> Get(string plate, CancellationToken cancellation);
		Task<Result.Result> Add(Car car, CancellationToken cancellation);
		Task<List<CarDto>> GetAll();
	//	Task<List<CarDto>> History(string plate, CancellationToken cancellation);
	}
}
