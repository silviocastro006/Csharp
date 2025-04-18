using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Shared.Dados.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaArtistas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Djavan", "Djavan Caetano Viana é um cantor, compositor, arranjador, produtor musical, empresário, violonista e ex-futebolista brasileiro.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Foo Fighters", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Pitty", "Priscilla Novaes Leone, mais conhecida como Pitty, é uma cantora, compositora, produtora, escritora, empresária, apresentadora e multi-instrumentista brasileira.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Gilberto Gil", "Gilberto Passos Gil Moreira é um cantor, compositor, multi-instrumentista, produtor musical, político e escritor brasileiro.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Foo Fighters", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Pitty", "Priscilla Novaes Leone, mais conhecida como Pitty, é uma cantora, compositora, produtora, escritora, empresária, apresentadora e multi-instrumentista brasileira.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Roque Abílio", "Recriando músicas famosas com uma reviravolta rockabilly, a Roque Abílio cativa o público com uma explosão autêntica do passado que ainda faz todo mundo dançar no presente.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData(
                "Artistas",
                new[] { "Nome", "Bio", "FotoPerfil" },
                new object[]
                {
                    "Luna Synth",
                    "Misturando synthwave e pop futurista, Luna Synth cria paisagens sonoras cósmicas que transportam o ouvinte direto para os anos 80 em uma nave espacial.",
                    "https://cdn.pixabay.com/photo/2021/01/14/11/54/woman-5914353_1280.jpg"
                });

            migrationBuilder.InsertData(
                "Artistas",
                new[] { "Nome", "Bio", "FotoPerfil" },
                new object[]
                {
                    "Os Versáteis",
                    "Com um repertório que vai do samba ao heavy metal em um único show, Os Versáteis são o verdadeiro camaleão da música brasileira.",
                    "https://cdn.pixabay.com/photo/2023/02/14/11/43/man-7788944_1280.jpg"
                });

            migrationBuilder.InsertData(
                "Artistas",
                new[] { "Nome", "Bio", "FotoPerfil" },
                new object[]
                {
                    "DJ Tempestade",
                    "Especialista em transformar trovões em batidas eletrônicas, DJ Tempestade é o nome por trás das pistas mais insanas do circuito underground.",
                    "https://cdn.pixabay.com/photo/2021/01/16/07/46/music-5921330_1280.jpg"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
