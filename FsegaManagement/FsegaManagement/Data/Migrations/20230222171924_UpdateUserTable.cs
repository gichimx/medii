using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FsegaManagement.Data.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAngajare",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prenume",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ZiDeNastere",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAngajare",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Nume",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prenume",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ZiDeNastere",
                table: "AspNetUsers");
        }
    }
}
