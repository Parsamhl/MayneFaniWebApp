using App.Domain.Core.Mayne.History.Data;
using App.Domain.Core.Mayne.History.Dto;
using App.Infra.Db.SqlServer;


namespace App.Infra.Repository.Ef.Mayne.History
{
    public class HistoryRepository : IHsitoryRepository
    {

        MayneDbContext _context;
        public HistoryRepository()
        {
            _context = new MayneDbContext();
        }

        public async Task<List<HistoryDto>> GetAllHistory(string Plate)
        {
            return await _context.CarHistory
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
