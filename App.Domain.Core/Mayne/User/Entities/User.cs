using App.Domain.Core.Mayne.City.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.User.Entities
{
    public class User
    {

        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int NationalCode { get; set; } 

        public string? Email {  get; set; }
        public string? PhoneNumber { get; set; }


       
        






    }
}
