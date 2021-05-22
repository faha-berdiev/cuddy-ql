﻿// <auto-generated />
using System;
using FamilyBusiness.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyBusiness.Migrations
{
    [DbContext(typeof(FamilyContext))]
    [Migration("20210504061456_modelsCreat")]
    partial class modelsCreat
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FamilyBusiness.Database.Models.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("FamilyBusiness.Database.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Amount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TransactionId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FamilyBusiness.Database.Models.Payment", b =>
                {
                    b.HasOne("FamilyBusiness.Database.Models.Family", null)
                        .WithMany("Payments")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("FamilyBusiness.Database.Models.Family", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}