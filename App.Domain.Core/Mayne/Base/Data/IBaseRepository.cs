using App.Domain.Core.Mayne.Base.Dto;
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

        Task<BaseDto> GetBase(int id , CancellationToken cancellation);
        Task<Result.Result> DeleteBase (int id , CancellationToken cancellation);
        Task<Result.Result> Add(Entities.Base newBase , CancellationToken cancellation);
        Task<List<BaseDto>> GetAll();
        

    }
}
