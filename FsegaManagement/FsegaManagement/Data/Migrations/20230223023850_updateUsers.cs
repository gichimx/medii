using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FsegaManagement.Data.Migrations
{
    public partial class updateUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f",
                column: "ConcurrencyStamp",
                value: "b99b7071-586f-4128-8d6d-0257ce5bf5eb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wefwef2-f2fwfe2f2-fwf23-f23f32f",
                column: "ConcurrencyStamp",
                value: "d2f82fb9-a30d-459a-a45f-765648fe8326");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20d1c8e9-ca29-4244-9b86-9735008371f8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e7dc34af-6dab-4b50-a379-0d97511f4804", true, "IGABRIEL76@YAHOO.COM", "AQAAAAEAACcQAAAAEPIbsTkpmJtNE48EPPtwYUD4RtgxmMyVMET07ryLbqNfzWPXoifufdkHX9Qqr3kR8g==", "a91bfc2d-fc0a-4e47-a791-25346abbc1aa", "IGABRIEL76@YAHOO.COM" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataAngajare", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Nume", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Prenume", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName", "ZiDeNastere" },
                values: new object[] { "f4fd1c8e9-ca29-4244-9b86-9735008f31f8", 0, "304310bc-38a1-4104-9bfd-a699744298f9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "User", "AQAAAAEAACcQAAAAEEnbVDwsVVyuniAAyfi9EKLMmF6P0bh608ClszRDHdMEsWWBLY06FxL2oadI3hXa9g==", null, false, "User", "13420cb1-e1d7-4c3f-a655-08f1b6986a13", null, false, "USER@GMAIL.COM", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f", "f4fd1c8e9-ca29-4244-9b86-9735008f31f8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f", "f4fd1c8e9-ca29-4244-9b86-9735008f31f8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4fd1c8e9-ca29-4244-9b86-9735008f31f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wef5wef2-f2fwfe2f2-fwf23-f23f9j32f",
                column: "ConcurrencyStamp",
                value: "1f857295-711f-464a-b524-226305a2b718");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "wefwef2-f2fwfe2f2-fwf23-f23f32f",
                column: "ConcurrencyStamp",
                value: "9676e257-93d8-45e0-a695-0941512cde29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20d1c8e9-ca29-4244-9b86-9735008371f8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fb4be038-5111-4f35-b04f-bf84a4b05310", false, null, "AQAAAAEAACcQAAAAEOW3nCelHE5VdSvaSP3tGUEvt28YYL2pqFW4XEOugvc3sXDktV9Ag7YRRibHRlul2A==", "3c9cf890-c235-4e5e-a1af-586982dbe7ea", null });
        }
    }
}
