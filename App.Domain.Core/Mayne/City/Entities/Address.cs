using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.City.Entities
{
    public class Address
    {
        public int cityId { get; set; }
        public string CityName { get; set; }

        public string NeighberHood { get; set; }
        public int NeghberHoodId { get; set; }

        public int PlateNo { get; set; }
 
    }
}
