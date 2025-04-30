using App.Domain.Core.Mayne.Result;
using App.Domain.Core.Mayne.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Mayne.Base
{
    public interface IBaseService
    {
        Task<Core.Mayne.Base.Entities.Base> GetBase(int id, CancellationToken cancellation);
        Task<Result> DeleteBase(int id, CancellationToken cancellation);
        Task<Result> Add(Core.Mayne.Base.Entities.Base newBase, CancellationToken cancellation);
        Task<List<Core.Mayne.Base.Entities.Base>> GetAll();
    }
}
