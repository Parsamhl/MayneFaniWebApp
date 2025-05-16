using App.Domain.Core.Mayne.History.Dto;

namespace App.Domain.Core.Mayne.History.Service
{
	public interface IHsitoryService
	{
		Task<List<HistoryDto>> GetAllRecords(CancellationToken token);
		Task<List<HistoryDto>> GetAllRecordsByPlate(string plate , CancellationToken token);

		
	}
}
