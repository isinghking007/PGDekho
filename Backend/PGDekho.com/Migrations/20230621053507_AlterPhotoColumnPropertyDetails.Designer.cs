﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PGDekho.com.DataContext;

#nullable disable

namespace PGDekho.com.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230621053507_AlterPhotoColumnPropertyDetails")]
    partial class AlterPhotoColumnPropertyDetails
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PGDekho.com.Models.PropertyDetails", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"), 1L, 1);

                    b.Property<string>("AgreementRequirement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookingAmount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Deposit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Double_Sharing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Five_BHK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Four_BHK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Four_Sharing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Locality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MinimumStay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("More_Sharing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("One_BHK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Single_Sharing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Three_BHK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Triple_Sharing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Two_BHK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("UserId");

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("PGDekho.com.Models.Register", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyOwner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Registers");
                });

            modelBuilder.Entity("PGDekho.com.Models.PropertyDetails", b =>
                {
                    b.HasOne("PGDekho.com.Models.Register", "Register")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Register");
                });
#pragma warning restore 612, 618
        }
    }
}
