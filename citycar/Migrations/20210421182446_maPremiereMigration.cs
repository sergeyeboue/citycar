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
                value: new DateTime(2021, 4, 21, 14, 24, 45, 976, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 21, 14, 24, 45, 981, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 21, 14, 24, 45, 981, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 21, 14, 24, 45, 981, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 21, 14, 24, 45, 981, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 21, 14, 24, 45, 981, DateTimeKind.Local).AddTicks(9530));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 111, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 113, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 113, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 113, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 113, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 14, 1, 2, 19, 113, DateTimeKind.Local).AddTicks(7857));
        }
    }
}
