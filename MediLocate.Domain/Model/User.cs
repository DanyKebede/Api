using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediLocate.Domain.Model
{
    public class User
    {
       public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public String ImageUrl { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
