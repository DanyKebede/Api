﻿// <auto-generated />
using System;
using MediLocate.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MediLocate.Dal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240407231122_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MediLocate.Domain.Model.Medicine", b =>
                {
                    b.Property<Guid>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Composition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MedicineName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("PharmacyId")
                        .HasColumnType("uuid");

                    b.Property<string>("SideEffects")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uses")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("MedicineId");

                    b.HasIndex("PharmacyId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.Pharmacy", b =>
                {
                    b.Property<Guid>("PharmacyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("ClosingHours")
                        .HasColumnType("interval");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Lattitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int[]>("OpeningDays")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<TimeSpan>("OpeningHour")
                        .HasColumnType("interval");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PharmacyId");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.PharmacyMedicine", b =>
                {
                    b.Property<Guid>("PharmacyId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("MedicineId")
                        .HasColumnType("uuid");

                    b.Property<string>("CountryofOrigin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Expiredate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("PharmacyId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("PharmacyMedicines");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.Medicine", b =>
                {
                    b.HasOne("MediLocate.Domain.Model.Pharmacy", null)
                        .WithMany("Medicines")
                        .HasForeignKey("PharmacyId");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.PharmacyMedicine", b =>
                {
                    b.HasOne("MediLocate.Domain.Model.Medicine", "Medicine")
                        .WithMany("pharmacyMedicines")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediLocate.Domain.Model.Pharmacy", "Pharmacy")
                        .WithMany("pharmacyMedicines")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.Medicine", b =>
                {
                    b.Navigation("pharmacyMedicines");
                });

            modelBuilder.Entity("MediLocate.Domain.Model.Pharmacy", b =>
                {
                    b.Navigation("Medicines");

                    b.Navigation("pharmacyMedicines");
                });
#pragma warning restore 612, 618
        }
    }
}
