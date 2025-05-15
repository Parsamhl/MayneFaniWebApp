using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Base.Services
{
	public interface IBaseService
	{
		Task<Entities.Base> GetBase(int id, CancellationToken cancellation);
		Task<Result.Result> DeleteBase(int id, CancellationToken cancellation);
		Task<Result.Result> Add(Entities.Base newBase, CancellationToken cancellation);
		Task<List<Entities.Base>> GetAll();
	}
}
