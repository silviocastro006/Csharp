using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class RelacionarArtistasAMusica : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                1,
                "ArtistaId",
                1
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                2,
                "ArtistaId",
                2
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                3,
                "ArtistaId",
                3
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                4,
                "ArtistaId",
                4
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                5,
                "ArtistaId",
                5
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                6,
                "ArtistaId",
                6
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                7,
                "ArtistaId",
                7
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                8,
                "ArtistaId",
                8
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                9,
                "ArtistaId",
                9
            );

            migrationBuilder.UpdateData(
                "Musicas",
                "Id",
                10,
                "ArtistaId",
                10
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MUSICAS");
        }
    }
}
