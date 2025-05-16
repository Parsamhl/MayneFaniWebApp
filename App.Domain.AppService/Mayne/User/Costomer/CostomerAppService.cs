using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.User.AppService.CostomerAppService;
using App.Domain.Core.Mayne.User.Dtos;
using App.Domain.Core.Mayne.User.Services.CostomerService;

namespace App.Domain.AppService.Mayne.User.Costomer
{
	public class CostomerAppService(ICostomerService _costomerService) : ICostomerAppService
	{
		public async Task<Result> AddAsync(Core.Mayne.User.Entities.Costomer costomer, CancellationToken token)
		{
			if (costomer.NationalCode.Length != 0)
			{
				if (costomer.NationalCode.Length == 10)
				{
					return await _costomerService.Add(costomer, token);	
				}
			}
			return new Result { IsSuccess = false, Message = "National Code Must be 10 character" };
		}

		public async Task<Result> DeletdAsync(string nationalCode, CancellationToken token)
		{
			return await _costomerService.DeleteCostomer(nationalCode);

		}

		public Task<List<UserDto>> GetAllAsync(CancellationToken token)
		{
			return _costomerService.GetAllAsync(token);
		}
	}
}
