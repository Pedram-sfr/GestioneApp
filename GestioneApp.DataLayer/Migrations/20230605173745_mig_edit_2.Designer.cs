﻿// <auto-generated />
using System;
using GestioneApp.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GestioneApp.DataLayer.Migrations
{
    [DbContext(typeof(GestioneAppContext))]
    [Migration("20230605173745_mig_edit_2")]
    partial class mig_edit_2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_JobTitle", b =>
                {
                    b.Property<int>("JobTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobTitleId"));

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobTitleId");

                    b.ToTable("tb_JobTitles");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_LegislativeAudit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Actions_ToBeCarriedOut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Actions_ToBeCarryOut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Activity_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Amb")
                        .HasColumnType("bit");

                    b.Property<bool?>("Applicable")
                        .HasColumnType("bit");

                    b.Property<int?>("COD")
                        .HasColumnType("int");

                    b.Property<bool?>("Confidential")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DaysNotice")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Energy")
                        .HasColumnType("bit");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("References_Law")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsible_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("SPriority")
                        .HasColumnType("bit");

                    b.Property<bool?>("SS")
                        .HasColumnType("bit");

                    b.Property<bool?>("Storaged")
                        .HasColumnType("bit");

                    b.Property<bool?>("Update_Normative")
                        .HasColumnType("bit");

                    b.Property<bool?>("WorkDoneCheck")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("WorkDoneDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkTitleId")
                        .HasColumnType("int");

                    b.Property<int>("jobTitleId")
                        .HasColumnType("int");

                    b.Property<int>("pATypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkTitleId");

                    b.HasIndex("jobTitleId");

                    b.HasIndex("pATypeId");

                    b.ToTable("tb_LegislativeAudits");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_PAType", b =>
                {
                    b.Property<int>("PAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PAId"));

                    b.Property<string>("PAName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PAId");

                    b.ToTable("tb_PATypes");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_WorkTitle", b =>
                {
                    b.Property<int>("WorkTitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkTitleId"));

                    b.Property<string>("WorkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkTitleId");

                    b.ToTable("tb_WorkTitles");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_LegislativeAudit", b =>
                {
                    b.HasOne("GestioneApp.DataLayer.Entities.tb_WorkTitle", "workTitle")
                        .WithMany("legislativeAudit")
                        .HasForeignKey("WorkTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestioneApp.DataLayer.Entities.tb_JobTitle", "jobTitle")
                        .WithMany("legislativeAudit")
                        .HasForeignKey("jobTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestioneApp.DataLayer.Entities.tb_PAType", "pAType")
                        .WithMany("legislativeAudit")
                        .HasForeignKey("pATypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("jobTitle");

                    b.Navigation("pAType");

                    b.Navigation("workTitle");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_JobTitle", b =>
                {
                    b.Navigation("legislativeAudit");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_PAType", b =>
                {
                    b.Navigation("legislativeAudit");
                });

            modelBuilder.Entity("GestioneApp.DataLayer.Entities.tb_WorkTitle", b =>
                {
                    b.Navigation("legislativeAudit");
                });
#pragma warning restore 612, 618
        }
    }
}
