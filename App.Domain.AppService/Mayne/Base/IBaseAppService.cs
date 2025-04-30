using App.Domain.Core.Mayne.Base.Dto;
using App.Domain.Core.Mayne.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Mayne.NewFolder
{
    public interface IBaseAppService
    {
        Task<Result> IsActive(int BaseNumber);
        Task <List<BaseDto>> GetBaseByCity(int cityId);
    }
}
