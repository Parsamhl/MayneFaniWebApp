using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.History.Dto
{
    public class HistoryDto
    {
        public string CarPlate { get; set; }
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string CarOwnerName { get; set; }
        public string ReseredBaseName { get; set; }
        public string ReseredBaseAddress { get; set; }
        public bool IsSucces { get; set; }
        public string IssueReport { get; set; }
        public DateTime ReferedDate { get; set; }
    }
}
