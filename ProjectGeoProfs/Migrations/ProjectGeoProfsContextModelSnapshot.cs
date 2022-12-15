﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectGeoProfs.Data;

#nullable disable

namespace ProjectGeoProfs.Migrations
{
    [DbContext(typeof(ProjectGeoProfsContext))]
    partial class ProjectGeoProfsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectGeoProfs.Models.VerlofAanvraag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Geaccepteerd")
                        .HasColumnType("bit");

                    b.Property<string>("Sector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VerlofBeginDatum")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VerlofEindDatum")
                        .HasColumnType("datetime2");

                    b.Property<string>("VerlofReden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VolledigeNaam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VerlofAanvraag");
                });
#pragma warning restore 612, 618
        }
    }
}
