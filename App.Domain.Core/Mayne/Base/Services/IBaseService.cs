

using App.Domain.Core.Mayne.Base.Dto;

namespace App.Domain.Core.Mayne.Base.Services
{
	public interface IBaseService
	{
		Task<BaseDto> GetBase(int id, CancellationToken cancellation);
		Task<Result.Result> DeleteBase(int id, CancellationToken cancellation);
		Task<Result.Result> Add(Entities.Base newBase, CancellationToken cancellation);
		Task<List<BaseDto>> GetAll();
	}
}
