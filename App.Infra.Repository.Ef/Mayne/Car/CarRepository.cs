using App.Domain.Core.Mayne.Cars.Data;
using App.Domain.Core.Mayne.Cars.Dtos;
using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.Result;
using App.Infra.Db.SqlServer;
using Microsoft.EntityFrameworkCore;


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
            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();
            return new Result { IsSuccess = true, Message = "Done" };

        }



        public async Task<List<CarDto>> GetAll()
        {
            return await _context.Cars.Select(x => new CarDto
            {
                CarBreand = x.CarBrand,
                CarName = x.CarName,
                OwnerName = x.CarOwner.Name + x.CarOwner.LastName,
                Plate = x.PlateNumber
            }).ToListAsync();
        }

        public async Task<Domain.Core.Mayne.Cars.Entities.Car> Get(string plate, CancellationToken cancellation)
        {
            return await _context.Cars.FirstOrDefaultAsync(x => x.PlateNumber == plate);
        }

        //public Task<List<CarDto>> History(string plate, CancellationToken cancellation)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
