﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPBDISlLab4.Data;

#nullable disable

namespace RPBDISlLab4.Migrations
{
    [DbContext(typeof(InspectionsDbContext))]
    [Migration("20241026165913_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RPBDISlLab4.Models.Enterprise", b =>
                {
                    b.Property<int>("EnterpriseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnterpriseId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnershipType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnterpriseId");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.Inspection", b =>
                {
                    b.Property<int>("InspectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InspectionId"));

                    b.Property<DateOnly>("CorrectionDeadline")
                        .HasColumnType("date");

                    b.Property<string>("CorrectionStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnterpriseId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("InspectionDate")
                        .HasColumnType("date");

                    b.Property<int>("InspectorId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("PaymentDeadline")
                        .HasColumnType("date");

                    b.Property<string>("PaymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PenaltyAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProtocolNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsiblePerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViolationTypeId")
                        .HasColumnType("int");

                    b.HasKey("InspectionId");

                    b.HasIndex("EnterpriseId");

                    b.HasIndex("InspectorId");

                    b.HasIndex("ViolationTypeId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.Inspector", b =>
                {
                    b.Property<int>("InspectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InspectorId"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InspectorId");

                    b.ToTable("Inspectors");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.ViolationType", b =>
                {
                    b.Property<int>("ViolationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ViolationTypeId"));

                    b.Property<int>("CorrectionPeriodDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PenaltyAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ViolationTypeId");

                    b.ToTable("ViolationType");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.Inspection", b =>
                {
                    b.HasOne("RPBDISlLab4.Models.Enterprise", "Enterprise")
                        .WithMany("Inspections")
                        .HasForeignKey("EnterpriseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPBDISlLab4.Models.Inspector", "Inspector")
                        .WithMany("Inspections")
                        .HasForeignKey("InspectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RPBDISlLab4.Models.ViolationType", "ViolationType")
                        .WithMany("Inspections")
                        .HasForeignKey("ViolationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enterprise");

                    b.Navigation("Inspector");

                    b.Navigation("ViolationType");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.Enterprise", b =>
                {
                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.Inspector", b =>
                {
                    b.Navigation("Inspections");
                });

            modelBuilder.Entity("RPBDISlLab4.Models.ViolationType", b =>
                {
                    b.Navigation("Inspections");
                });
#pragma warning restore 612, 618
        }
    }
}
