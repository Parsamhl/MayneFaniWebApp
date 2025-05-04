using App.Domain.Core.Mayne.Base.Entities;
using App.Domain.Core.Mayne.Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Reservation.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int ReservationCode { get; set; }
        public DateTime Date { get; set; }
        public Car Car { get; set; }
        public int CarId   { get; set; }
        public Base.Entities.Base Base { get; set; }
        public int BaseId { get; set; } 
       

        

    }
}
