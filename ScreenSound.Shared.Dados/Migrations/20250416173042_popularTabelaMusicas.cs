using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class popularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Manhã no Leblon", 2022 }); // Música para Léo Andrade

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Cidade Cinza", 2023 }); // Música para Banda Calmaria

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Neon Love", 2024 }); // Música para Sofia Reis

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Voz da Favela", 2022 }); // Música para MC Jota

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Coração na Porteira", 2023 }); // Música para Mariana Campos

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Brisas de Ipanema", 2021 }); // Música para Ricardo Novaes

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Pulso Urbano", 2024 }); // Música para Duo Sintonia

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Aria da Saudade", 2020 }); // Música para Beatriz Vargas

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Festa no Terreiro", 2023 }); // Música para Grupo Raiz Forte

            migrationBuilder.InsertData(
                "Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Ritmo Envolvente", 2024 }); // Música para Lucas Martins
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM MUSICAS");
        }
    }
}
