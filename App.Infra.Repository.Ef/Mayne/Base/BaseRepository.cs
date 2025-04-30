using App.Domain.Core.Mayne.Base.Data;
using App.Domain.Core.Mayne.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Repository.Ef.Mayne.Base
{
    public class BaseRepository : IBaseRepository
    {
        public Task<Result> Add(Domain.Core.Mayne.Base.Entities.Base newBase, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteBase(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        public Task<List<Domain.Core.Mayne.Base.Entities.Base>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Domain.Core.Mayne.Base.Entities.Base> GetBase(int id, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }
    }
}
