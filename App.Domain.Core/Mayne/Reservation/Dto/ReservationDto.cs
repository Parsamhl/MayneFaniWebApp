using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Reservation.Dto
{
    public class ReservationDto
    {
        public int ReservationCode { get; set; }
        public DateTime Date { get; set; }
        public int CarId { get; set; }
        public string BaseName { get; set; }
        public string CarPlate { get; set; }
        public string CarName { get; set; }
       

    }
}
