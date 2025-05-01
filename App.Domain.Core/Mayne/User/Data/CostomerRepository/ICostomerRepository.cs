

using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.User.Dtos;
using App.Domain.Core.Mayne.User.Entities;

namespace App.Domain.Core.Mayne.User.Data.CostomerRepository
{
    public interface ICostomerRepository
    {

        Task<Result.Result> Add(Costomer costomer, CancellationToken cancellation);
        Task<UserDto> GetCostomer(string NationalCode);
        Task<Result.Result> DeleteCostomer(string NationalCode);

    }
}
