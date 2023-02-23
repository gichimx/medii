using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FsegaManagement.Data.Migrations
{
    public partial class TabeleConcedii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipConcedii",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZileStandard = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataModificata = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipConcedii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConcediiAlocate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumarZile = table.Column<int>(type: "int", nullable: false),
                    TipConcediuId = table.Column<int>(type: "int", nullable: false),
                    AngajatId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataModificata = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcediiAlocate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConcediiAlocate_TipConcedii_TipConcediuId",
                        column: x => x.TipConcediuId,
                        principalTable: "TipConcedii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConcediiAlocate_TipConcediuId",
                table: "ConcediiAlocate",
                column: "TipConcediuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConcediiAlocate");

            migrationBuilder.DropTable(
                name: "TipConcedii");
        }
    }
}
