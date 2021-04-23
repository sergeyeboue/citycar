using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace citycar.Migrations
{
    public partial class maPremiereMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 899, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 914, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 914, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 914, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 914, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 22, 21, 22, 42, 914, DateTimeKind.Local).AddTicks(1022));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 427, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 429, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 429, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 429, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 429, DateTimeKind.Local).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 23, 7, 56, 44, 429, DateTimeKind.Local).AddTicks(4212));
        }
    }
}
