
using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.User.Data.CostomerRepository;
using App.Domain.Core.Mayne.User.Dtos;
using App.Domain.Core.Mayne.User.Services.CostomerService;

namespace App.Domain.Service.Mayne.User.Costomer
{
	public class CostomerService(ICostomerRepository _costomerRepository) : ICostomerService
	{
		public async Task<Result> Add(Core.Mayne.User.Entities.Costomer costomer, CancellationToken cancellation)
		{
			return await _costomerRepository.Add(costomer, cancellation);
		}

		public async Task<Result> DeleteCostomer(string NationalCode)
		{
			return await _costomerRepository.DeleteCostomer(NationalCode);
		}

		public async Task<List<UserDto>> GetAllAsync(CancellationToken token)
		{
			return await _costomerRepository.GetAllAsync(token);
		}

		public async Task<UserDto> GetCostomer(string NationalCode)
		{
			return await _costomerRepository.GetCostomer(NationalCode);
		}
	}
}
