using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class removedanotherlist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 6, 51, 50, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 6, 51, 55, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 6, 51, 55, DateTimeKind.Local).AddTicks(569));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 1, 29, 948, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 1, 29, 952, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 16, 1, 29, 952, DateTimeKind.Local).AddTicks(767));
        }
    }
}
