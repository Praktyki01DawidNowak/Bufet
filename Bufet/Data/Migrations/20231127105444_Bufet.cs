using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bufet.Data.Migrations
{
    public partial class Bufet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kan_Kategoria_KategoriaId",
                table: "Kan");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Kan_KanapkiId",
                table: "Zamowienia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kan",
                table: "Kan");

            migrationBuilder.RenameTable(
                name: "Kan",
                newName: "Kanapki");

            migrationBuilder.RenameIndex(
                name: "IX_Kan_KategoriaId",
                table: "Kanapki",
                newName: "IX_Kanapki_KategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kanapki",
                table: "Kanapki",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kanapki_Kategoria_KategoriaId",
                table: "Kanapki",
                column: "KategoriaId",
                principalTable: "Kategoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Kanapki_KanapkiId",
                table: "Zamowienia",
                column: "KanapkiId",
                principalTable: "Kanapki",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kanapki_Kategoria_KategoriaId",
                table: "Kanapki");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienia_Kanapki_KanapkiId",
                table: "Zamowienia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kanapki",
                table: "Kanapki");

            migrationBuilder.RenameTable(
                name: "Kanapki",
                newName: "Kan");

            migrationBuilder.RenameIndex(
                name: "IX_Kanapki_KategoriaId",
                table: "Kan",
                newName: "IX_Kan_KategoriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kan",
                table: "Kan",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kan_Kategoria_KategoriaId",
                table: "Kan",
                column: "KategoriaId",
                principalTable: "Kategoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienia_Kan_KanapkiId",
                table: "Zamowienia",
                column: "KanapkiId",
                principalTable: "Kan",
                principalColumn: "Id");
        }
    }
}
