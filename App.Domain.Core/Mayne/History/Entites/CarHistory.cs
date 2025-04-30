using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.History.Entites
{
    public class CarHistory
    {

        public int Id { get; set; }

        public DateTime Reservation { get; set; }

        public string IssueReport { get; set; }

        public bool IsSuccess { get; set; }
        public Cars.Entities.Car Car { get; set; }
        public int CarId { get; set; }

        public Base.Entities.Base ResevedBase { get; set; }
        public int BaseId { get; set; }

    }
}
