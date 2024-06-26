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
    [Migration("20230607195121_mig3")]
    partial class mig3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DaysNotice")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Energy")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PAType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Project")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("References_Law")
                        .IsRequired()
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

                    b.Property<string>("WorkTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_LegislativeAudits");
                });
#pragma warning restore 612, 618
        }
    }
}
