﻿// <auto-generated />
using Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Data_Access.Migrations
{
    [DbContext(typeof(NBAContext))]
    partial class NBAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data_Access.Models.Detail_Patient_Doctor", b =>
                {
                    b.Property<int>("Id_Detail")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DoctorId_Doctor");

                    b.Property<int>("PatientId_Patient");

                    b.HasKey("Id_Detail");

                    b.HasIndex("DoctorId_Doctor");

                    b.HasIndex("PatientId_Patient");

                    b.ToTable("Detail_Patient_Doctors");
                });

            modelBuilder.Entity("Data_Access.Models.Doctor", b =>
                {
                    b.Property<int>("Id_Doctor")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Credencial_Number");

                    b.Property<string>("Hospital")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Specialty")
                        .IsRequired();

                    b.HasKey("Id_Doctor");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Data_Access.Models.Patient", b =>
                {
                    b.Property<int>("Id_Patient")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<int>("Postal_Code");

                    b.Property<int>("Safe_Number");

                    b.HasKey("Id_Patient");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Data_Access.Models.Detail_Patient_Doctor", b =>
                {
                    b.HasOne("Data_Access.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId_Doctor")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Data_Access.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId_Patient")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
