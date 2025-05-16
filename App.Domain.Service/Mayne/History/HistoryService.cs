using App.Domain.Core.Mayne.History.Data;
using App.Domain.Core.Mayne.History.Dto;
using App.Domain.Core.Mayne.History.Service;

namespace App.Domain.Service.Mayne.History
{
	public class HistoryService(IHsitoryRepository _hsitoryRepository) : IHsitoryService
	{
		public async Task<List<HistoryDto>> GetAllRecords(CancellationToken token)
		{
			return await _hsitoryRepository.GetAllRecords(token);
		}

		public Task<List<HistoryDto>> GetAllRecordsByPlate(string plate, CancellationToken token)
		{
			throw new NotImplementedException();
		}
	}
}
