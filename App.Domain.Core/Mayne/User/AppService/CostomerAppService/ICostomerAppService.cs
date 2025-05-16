using App.Domain.Core.Mayne.User.Entities;

namespace App.Domain.Core.Mayne.User.AppService.CostomerAppService
{
	public interface ICostomerAppService
	{
		Task<Result.Result> AddAsync(Costomer costomer , CancellationToken token);
		Task<Result.Result> DeletdAsync(string nationalCode , CancellationToken token);	
		Task<List<Costomer>> GetAllAsync(CancellationToken token);
		
	}
}
