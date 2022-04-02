﻿// <auto-generated />
using System;
using CurrencyConverter.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CurrencyConverter.Data.Migrations
{
    [DbContext(typeof(CurrencyConverterDbContext))]
    partial class CurrencyConverterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CurrencyConverter.Data.Models.ConversionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("RequestedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("ConversionHistories");
                });

            modelBuilder.Entity("CurrencyConverter.Data.Models.CurrencyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Acronym")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CurrencyTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Acronym = "AED",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dirham dos Emirados"
                        },
                        new
                        {
                            Id = 2,
                            Acronym = "AFN",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Afghani do Afeganistão"
                        },
                        new
                        {
                            Id = 3,
                            Acronym = "ALL",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lek Albanês"
                        },
                        new
                        {
                            Id = 4,
                            Acronym = "AMD",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dram Armênio"
                        },
                        new
                        {
                            Id = 5,
                            Acronym = "ANG",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Guilder das Antilhas"
                        },
                        new
                        {
                            Id = 6,
                            Acronym = "AOA",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kwanza Angolano"
                        },
                        new
                        {
                            Id = 7,
                            Acronym = "ARS",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Peso Argentino"
                        },
                        new
                        {
                            Id = 8,
                            Acronym = "AUD",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dólar Australiano"
                        },
                        new
                        {
                            Id = 9,
                            Acronym = "AZN",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Manat Azeri"
                        },
                        new
                        {
                            Id = 10,
                            Acronym = "BAM",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Marco Conversível"
                        },
                        new
                        {
                            Id = 11,
                            Acronym = "BBD",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dólar de Barbados"
                        },
                        new
                        {
                            Id = 12,
                            Acronym = "BDT",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Taka de Bangladesh"
                        },
                        new
                        {
                            Id = 13,
                            Acronym = "BGN",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lev Búlgaro"
                        },
                        new
                        {
                            Id = 14,
                            Acronym = "BHD",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dinar do Bahrein"
                        },
                        new
                        {
                            Id = 15,
                            Acronym = "BIF",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Franco Burundinense"
                        },
                        new
                        {
                            Id = 16,
                            Acronym = "BND",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dólar de Brunei"
                        },
                        new
                        {
                            Id = 17,
                            Acronym = "BOB",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Boliviano"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
