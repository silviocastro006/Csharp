using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Oceano",  1989 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Flor de Lis", 1976 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Samurai", 1982 });

            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento" }, new object[] { "Se", 1992 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Horizonte Infinito", 2001 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Noite de Neon", 1987 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Caminhos Cruzados", 1999 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Vento Solar", 2020 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Ritmo Selvagem", 1995 });

            migrationBuilder.InsertData(
                "Musicas",
                new[] { "Nome", "AnoLancamento" },
                new object[] { "Ecos do Amanhã", 2015 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
