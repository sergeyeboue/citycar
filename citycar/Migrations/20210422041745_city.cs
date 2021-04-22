using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace citycar.Migrations
{
    public partial class city : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 321, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 324, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 324, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 324, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 324, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 17, 44, 324, DateTimeKind.Local).AddTicks(1222));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 301, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 304, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 304, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 304, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 304, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Commentaire",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 4, 21, 23, 14, 12, 304, DateTimeKind.Local).AddTicks(299));
        }
    }
}
