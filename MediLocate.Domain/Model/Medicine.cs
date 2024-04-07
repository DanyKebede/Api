using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediLocate.Domain.Model
{
    public class Medicine
    {
        public Guid MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string Composition { get; set; }
        public string Uses { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<PharmacyMedicine> pharmacyMedicines { get; set; }
    }
}
