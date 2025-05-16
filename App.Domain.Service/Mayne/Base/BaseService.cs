using App.Domain.Core.Mayne.Base.Data;
using App.Domain.Core.Mayne.Base.Dto;
using App.Domain.Core.Mayne.Base.Services;
using App.Domain.Core.Mayne.Result;


namespace App.Domain.Service.Mayne.Base
{
	public class BaseService(IBaseRepository _baseRepository) : IBaseService 
	{


		public async Task<Result> Add(Core.Mayne.Base.Entities.Base newBase, CancellationToken cancellation)
		{
			return await _baseRepository.Add(newBase, cancellation);
		}
		public async Task<Result> DeleteBase(int id, CancellationToken cancellation)
		{
			return await _baseRepository.DeleteBase(id, cancellation);
		}

		public async Task<List<BaseDto>> GetAll()
		{
			return await _baseRepository.GetAll();
		}

		public async Task<BaseDto> GetBase(int id, CancellationToken cancellation)
		{
			return await GetBase(id, cancellation);
		}
	}
}
