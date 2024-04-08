using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediLocate.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace MediLocate.Dal
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<PharmacyMedicine> PharmacyMedicines { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PharmacyMedicine>()
                .HasKey(pm => new { pm.PharmacyId, pm.MedicineId });

            modelBuilder.Entity<PharmacyMedicine>()
                .HasOne(pm => pm.Pharmacy)
                .WithMany(p => p.pharmacyMedicines)
                .HasForeignKey(pm => pm.PharmacyId);

            modelBuilder.Entity<PharmacyMedicine>()
                .HasOne(pm => pm.Medicine)
                .WithMany(m => m.pharmacyMedicines)
                .HasForeignKey(pm => pm.MedicineId);
        }
    }
}
