using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace workshop.wwwapi.Migrations
{
    /// <inheritdoc />
    public partial class AddedDoctorAppointment2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appointment",
                table: "appointment");

            migrationBuilder.RenameTable(
                name: "appointment",
                newName: "appointments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                table: "appointments",
                columns: new[] { "PatientId", "DoctorId" });

            migrationBuilder.UpdateData(
                table: "appointments",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { 1, 1 },
                column: "Booking",
                value: new DateTime(2024, 1, 30, 11, 23, 54, 608, DateTimeKind.Utc).AddTicks(7435));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "appointments",
                newName: "appointment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointment",
                table: "appointment",
                columns: new[] { "PatientId", "DoctorId" });

            migrationBuilder.UpdateData(
                table: "appointment",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { 1, 1 },
                column: "Booking",
                value: new DateTime(2024, 1, 30, 11, 22, 54, 64, DateTimeKind.Utc).AddTicks(6048));
        }
    }
}
