using App.Domain.Core.Mayne.City.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Base.Entities
{
    public class Base
    {

        public int BaseId { get; set; }
        public string BaseName { get; set; }
        public int BaseNumber { get; set; }
        public string BaseAdrress {  get; set; }    

        public City.Entities.City City { get; set; }
        public int CityId { get; set; }

       

        public List<Cars.Entities.Car> Cars { get; set; }

        
    }
}
