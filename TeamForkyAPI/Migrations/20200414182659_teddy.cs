using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamForkyAPI.Migrations
{
    public partial class teddy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CheckIn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ResourcesType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PatientResources",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false),
                    ResourcesID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientResources", x => new { x.PatientID, x.ResourcesID });
                    table.ForeignKey(
                        name: "FK_PatientResources_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientResources_Resources_ResourcesID",
                        column: x => x.ResourcesID,
                        principalTable: "Resources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "ID", "Birthday", "CheckIn", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "02/16/1991", new DateTime(2020, 4, 14, 11, 26, 58, 786, DateTimeKind.Local).AddTicks(460), "Teddy", 0 },
                    { 2, "03/23/1986", new DateTime(2020, 4, 14, 11, 26, 58, 805, DateTimeKind.Local).AddTicks(7710), "Joseph", 2 }
                });

            migrationBuilder.InsertData(
                table: "Resources",
                columns: new[] { "ID", "Description", "Name", "ResourcesType" },
                values: new object[,]
                {
                    { 1, "02/16/1991", "Teddy", 0 },
                    { 2, "02/16/1991", "Joseph", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientResources_ResourcesID",
                table: "PatientResources",
                column: "ResourcesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientResources");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
