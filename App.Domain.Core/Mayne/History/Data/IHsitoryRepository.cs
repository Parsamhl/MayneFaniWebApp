using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.History.Data
{
    public interface IHsitoryRepository
    {

        Task<List<Dto.HistoryDto>> GetAllHistory(string Plate);

    }
}
