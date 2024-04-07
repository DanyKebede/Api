using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediLocate.Domain.Model
{
    public class PharmacyMedicine
    {
        public Guid PharmacyId { get; set; }
        public Pharmacy Pharmacy { get; set; }
        public Guid MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime Expiredate { get; set; }
        public string Manufacturer { get; set; }
        public string CountryofOrigin { get; set; }

    }
}
