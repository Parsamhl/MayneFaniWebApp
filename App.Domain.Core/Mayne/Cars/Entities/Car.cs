using App.Domain.Core.Mayne.User.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Cars.Entities
{
    public class Car
    {

        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarBrand { get; set; }
        public string PlateNumber { get; set; }


        public Costomer CarOwner { get; set; }
        public int CarOwnerID { get; set; }

       


        public List<History.Entites.CarHistory> CarHistory { get; set; }


    }
}
