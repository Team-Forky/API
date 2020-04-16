using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class datatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientID",
                table: "Resources",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 23, 23, 39, 1, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 23, 23, 39, 4, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 23, 23, 39, 4, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.CreateIndex(
                name: "IX_Resources_PatientID",
                table: "Resources",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Patient_PatientID",
                table: "Resources",
                column: "PatientID",
                principalTable: "Patient",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Patient_PatientID",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_PatientID",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PatientID",
                table: "Resources");

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 18, 58, 57, 310, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 18, 58, 57, 313, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 18, 58, 57, 313, DateTimeKind.Local).AddTicks(9657));
        }
    }
}
