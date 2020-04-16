using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class datatest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 32, 35, 131, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 32, 35, 134, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 32, 35, 134, DateTimeKind.Local).AddTicks(4228));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 0, 16, 2, 199, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 0, 16, 2, 203, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 0, 16, 2, 203, DateTimeKind.Local).AddTicks(176));
        }
    }
}
