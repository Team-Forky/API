using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class datatest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 36, 52, 544, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4976));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
