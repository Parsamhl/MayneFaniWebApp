using App.Domain.Core.Mayne.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.User.Services.CostomerService
{
	public interface ICostomerService
	{
		Task<Result> Add(Entities.Costomer costomer, CancellationToken cancellation);
		Task<Entities.Costomer> GetCostomer();
		Task<Result> DeleteCostomer();
	}
}
