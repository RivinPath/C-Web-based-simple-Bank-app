﻿// <auto-generated />
using System;
using DBWebEFAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBWebEFAPI.Migrations
{
    [DbContext(typeof(DBManage))]
    [Migration("20241012064218_InitialCreateFive")]
    partial class InitialCreateFive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.33");

            modelBuilder.Entity("DBWebEFAPI.Data.Account", b =>
                {
                    b.Property<int>("accountNO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("balance")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("accountNO");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            accountNO = 1,
                            address = "No.55, Street 5, Colombo",
                            balance = "1000.00",
                            email = "himesh.h@gmail.com",
                            name = "Himesh",
                            phone = "0711234567"
                        },
                        new
                        {
                            accountNO = 2,
                            address = "No.1, Street 1, Colombo",
                            balance = "1500.00",
                            email = "rivin.r@gmail.com",
                            name = "Rivin",
                            phone = "0712345678"
                        },
                        new
                        {
                            accountNO = 3,
                            address = "No.2, Street 2, Colombo",
                            balance = "2000.00",
                            email = "dilhan.d@gmail.com",
                            name = "Dilhan",
                            phone = "0713456789"
                        },
                        new
                        {
                            accountNO = 4,
                            address = "No.3, Street 3, Colombo",
                            balance = "2500.00",
                            email = "anuk.a@gmail.com",
                            name = "Anuk",
                            phone = "0714567890"
                        },
                        new
                        {
                            accountNO = 5,
                            address = "No.4, Street 4, Colombo",
                            balance = "3000.00",
                            email = "yasith.y@gmail.com",
                            name = "Yasith",
                            phone = "0715678901"
                        },
                        new
                        {
                            accountNO = 6,
                            address = "No.6, Street 6, Colombo",
                            balance = "3500.00",
                            email = "thinali.t@gmail.com",
                            name = "Thinali",
                            phone = "0716789012"
                        });
                });

            modelBuilder.Entity("DBWebEFAPI.Data.Audit", b =>
                {
                    b.Property<string>("auditId")
                        .HasColumnType("TEXT");

                    b.Property<string>("auditRecord")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("auditId");

                    b.ToTable("Audits");

                    b.HasData(
                        new
                        {
                            auditId = "A001",
                            auditRecord = "Admin created account with ID 1"
                        },
                        new
                        {
                            auditId = "A002",
                            auditRecord = "Admin created account with ID 2"
                        },
                        new
                        {
                            auditId = "A003",
                            auditRecord = "Admin updated account with ID 3"
                        },
                        new
                        {
                            auditId = "A004",
                            auditRecord = "Admin deleted account with ID 4"
                        },
                        new
                        {
                            auditId = "A005",
                            auditRecord = "Admin updated account with ID 5"
                        });
                });

            modelBuilder.Entity("DBWebEFAPI.Data.Transaction", b =>
                {
                    b.Property<string>("transactionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("accountNO")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("transactionId");

                    b.ToTable("Transaction");

                    b.HasData(
                        new
                        {
                            transactionId = "T001",
                            accountNO = 1,
                            amount = 100.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9807),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T002",
                            accountNO = 1,
                            amount = 50.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9825),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T003",
                            accountNO = 1,
                            amount = 200.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9826),
                            description = "Transfer"
                        },
                        new
                        {
                            transactionId = "T004",
                            accountNO = 2,
                            amount = 250.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9828),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T005",
                            accountNO = 2,
                            amount = 100.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9828),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T006",
                            accountNO = 2,
                            amount = 300.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9831),
                            description = "Transfer"
                        },
                        new
                        {
                            transactionId = "T007",
                            accountNO = 3,
                            amount = 400.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9832),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T008",
                            accountNO = 3,
                            amount = 150.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9833),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T009",
                            accountNO = 3,
                            amount = 500.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9833),
                            description = "Transfer"
                        },
                        new
                        {
                            transactionId = "T010",
                            accountNO = 4,
                            amount = 350.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9835),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T011",
                            accountNO = 4,
                            amount = 200.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9836),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T012",
                            accountNO = 4,
                            amount = 450.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9837),
                            description = "Transfer"
                        },
                        new
                        {
                            transactionId = "T013",
                            accountNO = 5,
                            amount = 500.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9838),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T014",
                            accountNO = 5,
                            amount = 250.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9838),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T015",
                            accountNO = 5,
                            amount = 600.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9839),
                            description = "Transfer"
                        },
                        new
                        {
                            transactionId = "T016",
                            accountNO = 6,
                            amount = 700.00m,
                            date = new DateTime(2024, 10, 11, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9840),
                            description = "Deposit"
                        },
                        new
                        {
                            transactionId = "T017",
                            accountNO = 6,
                            amount = 300.00m,
                            date = new DateTime(2024, 10, 10, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9841),
                            description = "Withdrawal"
                        },
                        new
                        {
                            transactionId = "T018",
                            accountNO = 6,
                            amount = 800.00m,
                            date = new DateTime(2024, 10, 9, 12, 12, 18, 197, DateTimeKind.Local).AddTicks(9843),
                            description = "Transfer"
                        });
                });

            modelBuilder.Entity("DBWebEFAPI.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("picture")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "No.55, Street 5, Colombo",
                            email = "hh@gmail.com",
                            name = "Himesh",
                            password = "test1",
                            phone = "0712345678",
                            picture = "gamer.png"
                        },
                        new
                        {
                            Id = 2,
                            address = "No.1, Street 1, Colombo",
                            email = "rivin.r@gmail.com",
                            name = "Rivin",
                            password = "test2",
                            phone = "0722345678",
                            picture = "man.png"
                        },
                        new
                        {
                            Id = 3,
                            address = "No.2, Street 2, Colombo",
                            email = "dilhan.d@gmail.com",
                            name = "Dilhan",
                            password = "test3",
                            phone = "0732345678",
                            picture = "woman.png"
                        },
                        new
                        {
                            Id = 4,
                            address = "No.3, Street 3, Colombo",
                            email = "anuk.a@gmail.com",
                            name = "Anuk",
                            password = "test4",
                            phone = "0742345678",
                            picture = "profile.png"
                        },
                        new
                        {
                            Id = 5,
                            address = "No.4, Street 4, Colombo",
                            email = "yasith.y@gmail.com",
                            name = "Yasith",
                            password = "test5",
                            phone = "0752345678",
                            picture = "programmer.png"
                        },
                        new
                        {
                            Id = 6,
                            address = "No.6, Street 6, Colombo",
                            email = "thinali.t@gmail.com",
                            name = "Thinali",
                            password = "test6",
                            phone = "0762345678",
                            picture = "cat.png"
                        },
                        new
                        {
                            Id = 1000,
                            address = "No.6, Street 6, Colombo",
                            email = "admin1.t@gmail.com",
                            name = "Admin1",
                            password = "test1000",
                            phone = "0762345678",
                            picture = "cat.png"
                        },
                        new
                        {
                            Id = 1001,
                            address = "No.6, Street 6, Colombo",
                            email = "admin2.t@gmail.com",
                            name = "Admin2",
                            password = "test1001",
                            phone = "0762345678",
                            picture = "gamer.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
