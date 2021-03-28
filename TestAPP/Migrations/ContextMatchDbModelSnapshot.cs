﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestAPP.Models;

namespace TestAPP.Migrations
{
    [DbContext(typeof(ContextMatchDb))]
    partial class ContextMatchDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestAPP.Models.Match", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<DateTime>("MatchDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("match_date");

                    b.Property<DateTime>("MatchTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("match_time");

                    b.Property<int>("Sport")
                        .HasColumnType("int")
                        .HasColumnName("sport");

                    b.Property<string>("TeamA")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("team_a");

                    b.Property<string>("TeamB")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("team_b");

                    b.HasKey("ID");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("TestAPP.Models.MatchOdds", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MatchId")
                        .HasColumnType("int")
                        .HasColumnName("match_id");

                    b.Property<float>("Odd")
                        .HasColumnType("real")
                        .HasColumnName("odd");

                    b.Property<string>("Specifier")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("specifier");

                    b.HasKey("ID");

                    b.ToTable("MatchOdds");
                });
#pragma warning restore 612, 618
        }
    }
}