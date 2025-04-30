using App.Domain.Core.Mayne.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Mayne.User.Costomer
{
    public interface ICostomerService
    {
        Task<Result> Add(Core.Mayne.User.Entities.Costomer costomer, CancellationToken cancellation);
        Task<Core.Mayne.User.Entities.Costomer> GetCostomer();
        Task<Result> DeleteCostomer();
    }
}
