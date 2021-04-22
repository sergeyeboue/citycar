using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace citycar.Migrations
{
    public partial class cc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modele",
                table: "Voitures",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marque",
                table: "Voitures",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Voitures",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Proprietaire",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Proprietaire",
                type: "TEXT",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TextCommentaire",
                table: "Commentaire",
                type: "TEXT",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Modele",
                table: "Voitures",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Marque",
                table: "Voitures",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Voitures",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Prenom",
                table: "Proprietaire",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Nom",
                table: "Proprietaire",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "TextCommentaire",
                table: "Commentaire",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 500);

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
    }
}
