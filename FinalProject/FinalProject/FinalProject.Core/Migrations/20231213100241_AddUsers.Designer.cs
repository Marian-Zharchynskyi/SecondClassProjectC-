﻿// <auto-generated />
using System;
using FinalProject.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Core.Migrations
{
    [DbContext(typeof(FootballTeamContext))]
    [Migration("20231213100241_AddUsers")]
    partial class AddUsers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinalProject.Core.Entities.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CurrentMatchesAmount")
                        .HasColumnType("int");

                    b.Property<int>("DrawnMatches")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LoosedMatches")
                        .HasColumnType("int");

                    b.Property<int>("WonMatches")
                        .HasColumnType("int");

                    b.Property<int>("WonTrofies")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.CoachContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.ToTable("CoachContracts");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.FootballTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CoachId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoachId");

                    b.ToTable("FootballTeams");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Goals")
                        .HasColumnType("int");

                    b.Property<bool>("IsCaptain")
                        .HasColumnType("bit");

                    b.Property<string>("WorkingLeg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.PlayerContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerContracts");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.PlayerTransfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateRentEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateRentStart")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("FullFledged")
                        .HasColumnType("bit");

                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<bool?>("Rent")
                        .HasColumnType("bit");

                    b.Property<string>("TeamFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("PlayerTransfers");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.Property<int>("PlayersId")
                        .HasColumnType("int");

                    b.Property<int>("PositionsId")
                        .HasColumnType("int");

                    b.HasKey("PlayersId", "PositionsId");

                    b.HasIndex("PositionsId");

                    b.ToTable("PlayerPosition");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.CoachContract", b =>
                {
                    b.HasOne("FinalProject.Core.Entities.Coach", "Coach")
                        .WithMany("CoachContracts")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.FootballTeam", b =>
                {
                    b.HasOne("FinalProject.Core.Entities.Coach", "Coach")
                        .WithMany("FootballTeams")
                        .HasForeignKey("CoachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.PlayerContract", b =>
                {
                    b.HasOne("FinalProject.Core.Entities.Player", "Player")
                        .WithMany("PlayerContracts")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Core.Entities.FootballTeam", "Team")
                        .WithMany("PlayerContracts")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.PlayerTransfer", b =>
                {
                    b.HasOne("FinalProject.Core.Entities.Player", "Player")
                        .WithMany("PlayerTransfers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("PlayerPosition", b =>
                {
                    b.HasOne("FinalProject.Core.Entities.Player", null)
                        .WithMany()
                        .HasForeignKey("PlayersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.Core.Entities.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProject.Core.Entities.Coach", b =>
                {
                    b.Navigation("CoachContracts");

                    b.Navigation("FootballTeams");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.FootballTeam", b =>
                {
                    b.Navigation("PlayerContracts");
                });

            modelBuilder.Entity("FinalProject.Core.Entities.Player", b =>
                {
                    b.Navigation("PlayerContracts");

                    b.Navigation("PlayerTransfers");
                });
#pragma warning restore 612, 618
        }
    }
}
