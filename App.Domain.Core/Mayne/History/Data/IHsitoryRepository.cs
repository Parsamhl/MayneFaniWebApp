using App.Domain.Core.Mayne.History.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.History.Data
{
    public interface IHsitoryRepository
    {

		Task<List<HistoryDto>> GetAllRecords(CancellationToken token);
		Task<List<HistoryDto>> GetAllRecordsByPlate(string Plate);

    }
}
