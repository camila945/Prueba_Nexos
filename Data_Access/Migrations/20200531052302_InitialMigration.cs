using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Data_Access.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id_Doctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Credencial_Number = table.Column<int>(nullable: false),
                    Hospital = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Specialty = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id_Doctor);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id_Patient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Postal_Code = table.Column<int>(nullable: false),
                    Safe_Number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id_Patient);
                });

            migrationBuilder.CreateTable(
                name: "Detail_Patient_Doctors",
                columns: table => new
                {
                    Id_Detail = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DoctorId_Doctor = table.Column<int>(nullable: false),
                    PatientId_Patient = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail_Patient_Doctors", x => x.Id_Detail);
                    table.ForeignKey(
                        name: "FK_Detail_Patient_Doctors_Doctors_DoctorId_Doctor",
                        column: x => x.DoctorId_Doctor,
                        principalTable: "Doctors",
                        principalColumn: "Id_Doctor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detail_Patient_Doctors_Patients_PatientId_Patient",
                        column: x => x.PatientId_Patient,
                        principalTable: "Patients",
                        principalColumn: "Id_Patient",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Patient_Doctors_DoctorId_Doctor",
                table: "Detail_Patient_Doctors",
                column: "DoctorId_Doctor");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_Patient_Doctors_PatientId_Patient",
                table: "Detail_Patient_Doctors",
                column: "PatientId_Patient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detail_Patient_Doctors");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
