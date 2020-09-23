using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthClinic_MVC.Migrations
{
    public partial class AppointmetOptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Charge",
                table: "AppointmentReason");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "AppointmentReason");

            migrationBuilder.DropColumn(
                name: "AppointmentTime",
                table: "Appointment");

            migrationBuilder.AddColumn<string>(
                name: "Option",
                table: "AppointmentReason",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "AppointmentReason",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppDate",
                table: "Appointment",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Option",
                table: "AppointmentReason");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AppointmentReason");

            migrationBuilder.DropColumn(
                name: "AppDate",
                table: "Appointment");

            migrationBuilder.AddColumn<decimal>(
                name: "Charge",
                table: "AppointmentReason",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "AppointmentReason",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentTime",
                table: "Appointment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
