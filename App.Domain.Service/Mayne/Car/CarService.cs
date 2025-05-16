
using App.Domain.Core.Mayne.Cars.Data;
using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Cars.Service;
using App.Domain.Core.Mayne.Result;

namespace App.Domain.Service.Mayne.Car
{
	public class CarService(ICarRepository _carRepository) : IcarService
	{
		public async Task<Result> Add(Core.Mayne.Cars.Entities.Car car, CancellationToken cancellation)
		{

			return await _carRepository.Add(car, cancellation);

		}

		public async Task<Domain.Core.Mayne.Cars.Entities.Car> Get(string plate, CancellationToken cancellation)
		{
			return await _carRepository.Get(plate, cancellation);
		}

		public async Task<List<CarDto>> GetAll()
		{
			return await _carRepository.GetAll();
		}

		
	}
}
