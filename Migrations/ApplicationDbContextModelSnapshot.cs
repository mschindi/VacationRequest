﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VacationRequest.Database;

namespace VacationRequest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<long>("RolesId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("VacationRequest.UserRole.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Type = 3
                        },
                        new
                        {
                            Id = 2L,
                            Type = 1
                        });
                });

            modelBuilder.Entity("VacationRequest.UserRole.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<double>("CurrentVacationDays")
                        .HasColumnType("REAL");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("TotalVacationDays")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Wurststraße 69",
                            CurrentVacationDays = 10.0,
                            Email = "wurstfach69@wurstkönig.io",
                            FirstName = "Peter",
                            LastName = "Wurstgesicht",
                            TotalVacationDays = 25.0
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Ahmedstraße 1337",
                            CurrentVacationDays = 1.0,
                            Email = "ahma1337@raus.eu",
                            FirstName = "Hakan",
                            LastName = "Murruk",
                            TotalVacationDays = 25.0
                        });
                });

            modelBuilder.Entity("VacationRequest.VacationRequest.VacationRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AllowedVacation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("VacationEndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("VacationStartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("VacationRequests");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AllowedVacation = true,
                            Comment = "Meine Eier tun weh, ich brauche Urlaub",
                            Title = "Urlaubsantrag für Oktober",
                            UserId = 1L,
                            VacationEndDate = new DateTime(2021, 9, 27, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(640),
                            VacationStartDate = new DateTime(2021, 9, 20, 17, 1, 16, 266, DateTimeKind.Local).AddTicks(7320)
                        },
                        new
                        {
                            Id = 2L,
                            AllowedVacation = false,
                            Comment = "Ich will meine Füße massieren lassen",
                            Title = "Urlaubsantrag für November",
                            UserId = 2L,
                            VacationEndDate = new DateTime(2021, 9, 30, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(6750),
                            VacationStartDate = new DateTime(2021, 9, 20, 17, 1, 16, 282, DateTimeKind.Local).AddTicks(6080)
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("VacationRequest.UserRole.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VacationRequest.UserRole.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VacationRequest.VacationRequest.VacationRequest", b =>
                {
                    b.HasOne("VacationRequest.UserRole.User", "User")
                        .WithMany("VacationRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("VacationRequest.UserRole.User", b =>
                {
                    b.Navigation("VacationRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
