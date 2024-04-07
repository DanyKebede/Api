using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediLocate.Dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    PharmacyId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Lattitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    OpeningHour = table.Column<TimeSpan>(type: "interval", nullable: false),
                    ClosingHours = table.Column<TimeSpan>(type: "interval", nullable: false),
                    OpeningDays = table.Column<int[]>(type: "integer[]", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.PharmacyId);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicineName = table.Column<string>(type: "text", nullable: false),
                    Composition = table.Column<string>(type: "text", nullable: false),
                    Uses = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    SideEffects = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    PharmacyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineId);
                    table.ForeignKey(
                        name: "FK_Medicines_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacyId");
                });

            migrationBuilder.CreateTable(
                name: "PharmacyMedicines",
                columns: table => new
                {
                    PharmacyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MedicineId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Expiredate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Manufacturer = table.Column<string>(type: "text", nullable: false),
                    CountryofOrigin = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyMedicines", x => new { x.PharmacyId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_PharmacyMedicines_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PharmacyMedicines_Pharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "Pharmacies",
                        principalColumn: "PharmacyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_PharmacyId",
                table: "Medicines",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyMedicines_MedicineId",
                table: "PharmacyMedicines",
                column: "MedicineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PharmacyMedicines");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Pharmacies");
        }
    }
}
