

using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.User.Entities;

namespace App.Domain.Core.Mayne.User.Data.CostomerRepository
{
    public interface ICostomerRepository
    {

        Task<Result.Result> Add(Costomer costomer, CancellationToken cancellation);
        Task<Costomer> GetCostomer();
        Task<Result.Result> DeleteCostomer();

    }
}
