using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class test222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 14, 24, 45, 436, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 14, 24, 45, 455, DateTimeKind.Local).AddTicks(3740));

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "ID", "Birthday", "CheckIn", "Name", "Status" },
                values: new object[] { 3, "08/29/1992", new DateTime(2020, 4, 14, 14, 24, 45, 455, DateTimeKind.Local).AddTicks(3790), "Matthew", 2 });

            migrationBuilder.InsertData(
                table: "PatientResources",
                columns: new[] { "PatientID", "ResourcesID", "ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 4 }
                });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Specialist in C# surgery", "Dr. Amanda" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ResourcesType" },
                values: new object[] { "Specialist in education touch up", "Dr. Brook", 0 });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "Description", "Name", "ResourcesType" },
                values: new object[] { 3, "Bacteria sanitizer", "Microwave", 1 });

            migrationBuilder.InsertData(
                table: "PatientResources",
                columns: new[] { "PatientID", "ResourcesID", "ID" },
                values: new object[] { 3, 2, 3 });

            migrationBuilder.InsertData(
                table: "PatientResources",
                columns: new[] { "PatientID", "ResourcesID", "ID" },
                values: new object[] { 1, 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientResources",
                keyColumns: new[] { "PatientID", "ResourcesID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PatientResources",
                keyColumns: new[] { "PatientID", "ResourcesID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PatientResources",
                keyColumns: new[] { "PatientID", "ResourcesID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PatientResources",
                keyColumns: new[] { "PatientID", "ResourcesID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 1,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 11, 26, 58, 786, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "Patient",
                keyColumn: "ID",
                keyValue: 2,
                column: "CheckIn",
                value: new DateTime(2020, 4, 14, 11, 26, 58, 805, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "02/16/1991", "Teddy" });

            migrationBuilder.UpdateData(
                table: "Resources",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Name", "ResourcesType" },
                values: new object[] { "02/16/1991", "Joseph", 2 });
        }
    }
}
