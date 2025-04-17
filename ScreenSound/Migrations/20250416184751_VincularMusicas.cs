using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class VincularMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArtistaId",
                value: 1
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArtistaId",
                value: 2
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArtistaId",
                value: 3
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArtistaId",
                value: 4
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArtistaId",
                value: 5
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArtistaId",
                value: 6
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 7,
                column: "ArtistaId",
                value: 7
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 8,
                column: "ArtistaId",
                value: 8
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 9,
                column: "ArtistaId",
                value: 9
            );

            migrationBuilder.UpdateData(
                table: "Musicas",
                keyColumn: "Id",
                keyValue: 10,
                column: "ArtistaId",
                value: 10
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MUSICAS");
        }
    }
}
