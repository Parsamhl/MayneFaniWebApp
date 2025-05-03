using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.User.Data.CostomerRepository;
using App.Domain.Core.Mayne.User.Dtos;
using App.Domain.Core.Mayne.User.Entities;
using App.Infra.Db.SqlServer;
using Microsoft.EntityFrameworkCore;



namespace App.Infra.Repository.Ef.Mayne.User.Costmer
{
    public class CostomerRepository : ICostomerRepository
    {
        MayneDbContext _context;
        public CostomerRepository()
        {
            _context = new MayneDbContext();
        }

        public async Task<Result> Add(Costomer costomer, CancellationToken cancellation)
        {
            if(costomer is null)
                return new Result { IsSuccess = false, Message = "Costomer is null" };

            await _context.Costomers.AddAsync(costomer);
            await _context.SaveChangesAsync();

            return new Result { IsSuccess = true, Message = "Done" };
        }

        public async Task<Result> DeleteCostomer(string NationalCode)
        {
            var costomer = _context.Costomers.FirstOrDefault(x => x.NationalCode == NationalCode);

            if(costomer is null) 
                return new Result { IsSuccess = false, Message = "Costomer not found" };

            //await _context.Costomers.RemoveAsync(costomer);
            await _context.SaveChangesAsync();
            return new Result { IsSuccess = true, Message = "Done" };

        }

        public async Task<UserDto> GetCostomer(string NationalCode)
        {
            return await _context.Costomers.Where(x => x.NationalCode == NationalCode)
                .Select(x => new UserDto
                {
                    Name = x.Name,
                    LastName = x.LastName,
                    NationalCode = x.NationalCode,
                    PhoneNumber = x.PhoneNumber,

                }).FirstOrDefaultAsync();
        }
    }
}
