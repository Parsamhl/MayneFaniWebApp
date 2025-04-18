using App.Domain.Core.Mayne.Base.Entities;
using App.Domain.Core.Mayne.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Base.Data
{
    public interface IBaseRepository
    {

        Task<Base.Entities.Base> GetBase(int id , CancellationToken cancellation);
        Task<Result.Result> DeleteBase (int id , CancellationToken cancellation);
        Task<Result.Result> Add(Base.Entities.Base newBase , CancellationToken cancellation);
        Task<List<Base.Entities.Base>> GetAll();
        

    }
}
