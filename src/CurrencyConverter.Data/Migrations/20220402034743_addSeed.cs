using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Data.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CurrencyTypes",
                columns: new[] { "Id", "Acronym", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, "AED", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dirham dos Emirados" },
                    { 15, "BIF", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franco Burundinense" },
                    { 14, "BHD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dinar do Bahrein" },
                    { 13, "BGN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lev Búlgaro" },
                    { 12, "BDT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taka de Bangladesh" },
                    { 11, "BBD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dólar de Barbados" },
                    { 10, "BAM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marco Conversível" },
                    { 16, "BND", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dólar de Brunei" },
                    { 9, "AZN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manat Azeri" },
                    { 7, "ARS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peso Argentino" },
                    { 6, "AOA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kwanza Angolano" },
                    { 5, "ANG", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guilder das Antilhas" },
                    { 4, "AMD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dram Armênio" },
                    { 3, "ALL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lek Albanês" },
                    { 2, "AFN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afghani do Afeganistão" },
                    { 8, "AUD", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dólar Australiano" },
                    { 17, "BOB", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boliviano" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CurrencyTypes",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
