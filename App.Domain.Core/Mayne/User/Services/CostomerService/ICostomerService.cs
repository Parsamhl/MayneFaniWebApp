

using App.Domain.Core.Mayne.User.Dtos;

namespace App.Domain.Core.Mayne.User.Services.CostomerService
{
	public interface ICostomerService
	{
		Task<Result.Result> Add(Entities.Costomer costomer, CancellationToken cancellation);
		Task<UserDto> GetCostomer(string NationalCode);
		Task<Result.Result> DeleteCostomer(string nationalCode);
		Task<List<UserDto>> GetAllAsync(CancellationToken token);
	}
}
