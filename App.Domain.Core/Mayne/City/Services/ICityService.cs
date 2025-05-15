using App.Domain.Core.Mayne.City.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.City.Services
{
	public interface ICityService
	{
		Task<List<CityDto>> GetAll();
	}
}
