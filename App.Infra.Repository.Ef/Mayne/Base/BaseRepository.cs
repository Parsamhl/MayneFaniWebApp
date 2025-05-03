using App.Domain.Core.Mayne.Base.Data;
using App.Domain.Core.Mayne.Cars.Entities;
using App.Domain.Core.Mayne.Base.Dto;
using App.Domain.Core.Mayne.Result;
using App.Infra.Db.SqlServer;

namespace App.Infra.Repository.Ef.Mayne.Base
{
    public class BaseRepository : IBaseRepository
    {
        private readonly MayneDbContext _context;
        public BaseRepository()
        {
            _context = new MayneDbContext();
        }
        public async Task<Result> Add(Domain.Core.Mayne.Base.Entities.Base newBase, CancellationToken cancellation)
        {
            if (newBase is null)
                 return new Result { IsSuccess = false, Message = "Car is null" };

            await _context.Bases.AddAsync(newBase);
            await _context.SaveChangesAsync();
            return new Result { IsSuccess = true, Message = "Done" };
        }

        public async Task<Result> DeleteBase(int id, CancellationToken cancellation)
        {
            var b = _context.Bases.FirstOrDefault(x => x.BaseId == id);
            if (b is null)
                return new Result { IsSuccess = false, Message = "not exist" };

            _context.Bases.Remove(b);
            await _context.SaveChangesAsync();
            return new Result { IsSuccess = true, Message = "Done" };
        }

        public Task<List<BaseDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        Task<BaseDto> IBaseRepository.GetBase(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
