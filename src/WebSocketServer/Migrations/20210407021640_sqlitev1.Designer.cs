﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebSocketServer.Data;

namespace WebSocketServer.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20210407021640_sqlitev1")]
    partial class sqlitev1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("WebSocketServer.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Introduction = "Great Company",
                            Name = "Microsoft"
                        },
                        new
                        {
                            Id = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Introduction = "Don't be evil",
                            Name = "Google"
                        });
                });

            modelBuilder.Entity("WebSocketServer.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("adbcd2eb-e25f-4bc1-8631-5568535c14ce"),
                            Age = 15,
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Name = "A"
                        },
                        new
                        {
                            Id = new Guid("08a3e81a-8250-4f97-95d6-2a5fd178bbc2"),
                            Age = 18,
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Name = "A"
                        },
                        new
                        {
                            Id = new Guid("525b9fde-e07f-4973-ba92-bd7abb597242"),
                            Age = 20,
                            CompanyId = new Guid("bbdee09c-089b-4d30-bece-44df5923716c"),
                            Name = "A"
                        },
                        new
                        {
                            Id = new Guid("4857af7c-6c05-4707-b1f2-96b5637e07ba"),
                            Age = 99,
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Name = "A"
                        },
                        new
                        {
                            Id = new Guid("300d8e78-52f7-4ba0-9dbe-59af0291aed7"),
                            Age = 59,
                            CompanyId = new Guid("6fb600c1-9011-4fd7-9234-881379716440"),
                            Name = "A"
                        });
                });

            modelBuilder.Entity("WebSocketServer.Entities.ErrorLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Log")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uid")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("WebSocketServer.Entities.RunClock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCheck")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SIM")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("RunClocks");
                });

            modelBuilder.Entity("WebSocketServer.Entities.Employee", b =>
                {
                    b.HasOne("WebSocketServer.Entities.Company", null)
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebSocketServer.Entities.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
