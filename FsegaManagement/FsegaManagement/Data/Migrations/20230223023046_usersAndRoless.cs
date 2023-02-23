using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FsegaManagement.Data.Migrations
{
    public partial class usersAndRoless : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f", "1f857295-711f-464a-b524-226305a2b718", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "wefwef2-f2fwfe2f2-fwf23-f23f32f", "9676e257-93d8-45e0-a695-0941512cde29", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataAngajare", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nume", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prenume", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName", "ZiDeNastere" },
                values: new object[] { "20d1c8e9-ca29-4244-9b86-9735008371f8", 0, "fb4be038-5111-4f35-b04f-bf84a4b05310", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "igabriel76@yahoo.com", false, false, null, "IGABRIEL76@YAHOO.COM", null, "Ichim", "AQAAAAEAACcQAAAAEOW3nCelHE5VdSvaSP3tGUEvt28YYL2pqFW4XEOugvc3sXDktV9Ag7YRRibHRlul2A==", null, false, "Gabriel", "3c9cf890-c235-4e5e-a1af-586982dbe7ea", null, false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "wefwef2-f2fwfe2f2-fwf23-f23f32f", "20d1c8e9-ca29-4244-9b86-9735008371f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "wefwef2-f2fwfe2f2-fwf23-f23f32f", "20d1c8e9-ca29-4244-9b86-9735008371f8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wefwef2-f2fwfe2f2-fwf23-f23f32f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20d1c8e9-ca29-4244-9b86-9735008371f8");
        }
    }
}
