﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WypozyczalniaRowerowaProjektAIookAPI.Data;

#nullable disable

namespace APIWypozyczalniaRowerowaProjektAIooK.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231202131657_123")]
    partial class _123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIWypozyczalniaRowerowaProjektAIooK.Models.Borrow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBorrow")
                        .HasColumnType("datetime2");

                    b.Property<int>("HoursCount")
                        .HasColumnType("int");

                    b.Property<int>("IdBike")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdBike");

                    b.ToTable("Borrows");
                });

            modelBuilder.Entity("WypozyczalniaRowerowaProjektAIookAPI.Models.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bikes");
                });

            modelBuilder.Entity("APIWypozyczalniaRowerowaProjektAIooK.Models.Borrow", b =>
                {
                    b.HasOne("WypozyczalniaRowerowaProjektAIookAPI.Models.Bike", "Bike")
                        .WithMany("Borrows")
                        .HasForeignKey("IdBike")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bike");
                });

            modelBuilder.Entity("WypozyczalniaRowerowaProjektAIookAPI.Models.Bike", b =>
                {
                    b.Navigation("Borrows");
                });
#pragma warning restore 612, 618
        }
    }
}