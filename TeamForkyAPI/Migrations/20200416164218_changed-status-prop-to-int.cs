using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class changedstatusproptoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 16, 9, 42, 17, 712, DateTimeKind.Local).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CheckIn", "Status" },
                values: new object[] { new DateTime(2020, 4, 16, 9, 42, 17, 716, DateTimeKind.Local).AddTicks(3757), 0 });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CheckIn", "Status" },
                values: new object[] { new DateTime(2020, 4, 16, 9, 42, 17, 716, DateTimeKind.Local).AddTicks(3823), 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CheckIn", "Status" },
                values: new object[] { new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4913), 2 });

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CheckIn", "Status" },
                values: new object[] { new DateTime(2020, 4, 15, 11, 36, 52, 547, DateTimeKind.Local).AddTicks(4976), 2 });
        }
    }
}
