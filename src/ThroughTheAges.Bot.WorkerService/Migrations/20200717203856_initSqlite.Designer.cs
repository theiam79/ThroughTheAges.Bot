﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThroughTheAges.Bot.WorkerService;

namespace ThroughTheAges.Bot.WorkerService.Migrations
{
    [DbContext(typeof(CardContext))]
    [Migration("20200717203856_initSqlite")]
    partial class initSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("ThroughTheAges.Bot.WorkerService.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CivilActions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountFourPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountThreePlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountTwoPlayers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CultureProduction")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FoodProduction")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Happiness")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MilitaryActions")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResourceProduction")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScienceProduction")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StrengthProduction")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TechCost")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("CardId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            CardId = 1,
                            Age = 1,
                            BuildCost = "3",
                            Category = 5,
                            CivilActions = 0,
                            CountFourPlayers = 2,
                            CountThreePlayers = 2,
                            CountTwoPlayers = 1,
                            CultureProduction = 0,
                            FoodProduction = 0,
                            Happiness = 2,
                            MilitaryActions = 0,
                            Name = "Bread & Circuses",
                            ResourceProduction = 0,
                            ScienceProduction = 0,
                            StrengthProduction = 1,
                            TechCost = 3,
                            Text = "",
                            Type = 1
                        },
                        new
                        {
                            CardId = 2,
                            Age = 1,
                            BuildCost = "3",
                            Category = 6,
                            CivilActions = 0,
                            CountFourPlayers = 2,
                            CountThreePlayers = 2,
                            CountTwoPlayers = 2,
                            CultureProduction = 1,
                            FoodProduction = 0,
                            Happiness = 0,
                            MilitaryActions = 0,
                            Name = "Printing Press",
                            ResourceProduction = 0,
                            ScienceProduction = 1,
                            StrengthProduction = 0,
                            TechCost = 3,
                            Text = "",
                            Type = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
