using App.Domain.Core.Mayne.History.Data;
using App.Domain.Core.Mayne.History.Dto;
using App.Infra.Db.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Repository.Ef.Mayne.History
{
    public class HistoryRepository : IHsitoryRepository
    {

        MayneDbContext _context;
        public HistoryRepository(MayneDbContext context)
        {
            _context = context;
        }

		public async Task<List<HistoryDto>> GetAllRecords(CancellationToken token)
		{
            return await _context.CarHistory
                .AsNoTracking()
               .Select(x => new HistoryDto
               {
                   CarBrand = x.Car.CarBrand,
                   CarName = x.Car.CarName,
                   CarOwnerName = x.Car.CarOwner.Name + " " + x.Car.CarOwner.LastName,
                   CarPlate = x.Car.PlateNumber,
                   ReferedDate = x.Reservation,
                   IssueReport = x.IssueReport,
               }).ToListAsync();
		}

		public async Task<List<HistoryDto>> GetAllRecordsByPlate(string Plate)
        {
            return await _context.CarHistory
                .AsNoTracking()
                .Where(x => x.Car.PlateNumber == Plate)
                .Select(x => new HistoryDto
                {
                    CarBrand = x.Car.CarBrand,
                    CarName = x.Car.CarName,
                    CarOwnerName = x.Car.CarOwner.Name + " " + x.Car.CarOwner.LastName,
                    CarPlate = x.Car.PlateNumber,
                    ReferedDate = x.Reservation,
                    IssueReport = x.IssueReport,
                }).ToListAsync();
        }
    }
}
