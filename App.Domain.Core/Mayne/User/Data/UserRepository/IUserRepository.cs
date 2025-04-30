using App.Domain.Core.Mayne.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.User.Data.UserRepository
{
    public interface IUserRepository
    {
        Task<Result.Result> Add(User.Entities.User costomer, CancellationToken cancellation);
       // Task< > GetCostomer();
        Task<Result.Result> DeleteCostomer();
    }
}
