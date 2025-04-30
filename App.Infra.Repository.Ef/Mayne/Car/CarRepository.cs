using App.Domain.Core.Mayne.Cars.Data;
using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Result;
using App.Infra.Db.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.Mayne.Car
{
    public class CarRepository : ICarRepository
    {

        private readonly MayneDbContext _context;

        public CarRepository()
        {
            _context = new MayneDbContext();
        }

        public async Task<Result> Add(Domain.Core.Mayne.Cars.Entities.Car car, CancellationToken cancellation)
        {
            if (car is null)
            {
                return new Result { IsSuccess = false, Message = "Car is null" };

            }
            await _context.Cars.Add(car);
            await _context.SaveChangesAsync();
            return new Result { IsSuccess = true, Message = "Done" };

        }

        public async Task<Result> Get(string plate, CancellationToken cancellation)
        {
            return await _context.Cars.FirstOrDefault(x => x.PlateNumber == plate);

        }

        public async Task<List<CarDto>> GetAll()
        {
            return await _context.Cars.Select(x => new CarDto
            {
                CarBreand = x.CarBrand,
                CarName = x.CarName,
                OwnerName = x.CarOwner.Name + x.CarOwner.LastName,
                Plate = x.PlateNumber
            });
        }

        //public Task<List<CarDto>> History(string plate, CancellationToken cancellation)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
