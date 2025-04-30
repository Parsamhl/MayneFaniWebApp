using App.Domain.Core.Mayne.City.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Mayne.City
{
    public interface ICityAppService
    {
        Task<List<CityDto>> GetAllCities();
    }
}
