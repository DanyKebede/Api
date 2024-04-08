using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediLocate.Domain.Model
{
    public class Prescription
    {
        public Guid PrescriptionId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public Guid PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public string Description { get; set; }
        public int Frequency { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
