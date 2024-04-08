using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediLocate.Domain.Model
{
    public class Pharmacy
    {
        public Guid PharmacyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
        public TimeSpan OpeningHour { get; set; }
        public TimeSpan ClosingHours { get; set; }
        public List<DayOfWeek> OpeningDays { get; set; }
        public List<Medicine> Medicines { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<PharmacyMedicine> pharmacyMedicines { get; set; }


    }
}
