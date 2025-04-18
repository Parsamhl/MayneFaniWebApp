using App.Domain.Core.Mayne.Base.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.City.Entities
{
    public class City
    {

        public int Id { get; set; }
        public string CityName { get; set; }

        public List<Base.Entities.Base> Bases { get; set; }
        public int BaseId { get; set; }
    }
}
