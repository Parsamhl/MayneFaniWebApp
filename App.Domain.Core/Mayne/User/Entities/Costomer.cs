using App.Domain.Core.Mayne.Cars.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.User.Entities
{
    public class Costomer : User
    {
        public List<Car> CostomerCars { get; set; }

    }
}
