using Microsoft.EntityFrameworkCore.Migrations;
using Org.BouncyCastle.Crypto.Digests;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class popularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Léo Andrade", "Cantor e compositor de MPB, conhecido por suas letras poéticas e melodias suaves que mesclam influências da bossa nova e do pop contemporâneo. Lançou 3 álbuns de estúdio.", "https://via.placeholder.com/150/0000FF/FFFFFF?text=Leo+A" });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Banda Calmaria", "Grupo de rock alternativo com influências do indie e post-punk. Famosos pela energia contagiante de seus shows ao vivo e letras introspectivas.", "https://via.placeholder.com/150/FF0000/FFFFFF?text=B.+Calmaria" });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Sofia Reis", "Artista pop em ascensão, seus singles dançantes e clipes visualmente marcantes conquistaram as paradas de sucesso e as plataformas de streaming.", "https://via.placeholder.com/150/00FF00/000000?text=Sofia+R." });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "MC Jota", "Rapper e produtor da cena hip-hop nacional, conhecido por suas rimas afiadas que abordam críticas sociais e a realidade urbana, sobre batidas originais.", "https://via.placeholder.com/150/FFFF00/000000?text=MC+Jota" });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Mariana Campos", "Cantora sertaneja de voz potente e carisma marcante. Interpreta desde clássicos do gênero até músicas autorais que falam sobre amor e empoderamento feminino.", "https://via.placeholder.com/150/FF00FF/FFFFFF?text=Mariana+C." });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Ricardo Novaes", "Violonista virtuoso e compositor instrumental, transita entre o choro, o jazz brasileiro e a música clássica. Reconhecido por sua técnica apurada e sensibilidade.", "https://via.placeholder.com/150/00FFFF/000000?text=Ricardo+N." });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Duo Sintonia", "Dupla de DJs e produtores de música eletrônica, conhecidos por seus sets vibrantes que misturam house, techno e elementos de música brasileira, agitando pistas no Brasil e exterior.", "https://via.placeholder.com/150/FFA500/FFFFFF?text=Duo+Sintonia" });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Beatriz Vargas", "Cantora lírica (Mezzo-soprano) com carreira internacional, aclamada por suas performances em óperas e recitais. Possui um vasto repertório que inclui Villa-Lobos e Mozart.", "https://via.placeholder.com/150/800080/FFFFFF?text=Beatriz+V." });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Grupo Raiz Forte", "Conjunto tradicional de samba e pagode, dedicado a preservar e renovar o gênero. Famosos pelas rodas de samba animadas e pelo resgate de compositores clássicos.", "https://via.placeholder.com/150/A52A2A/FFFFFF?text=G.+Raiz+Forte" });

        migrationBuilder.InsertData(
            "Artistas",
            new string[] { "Nome", "Bio", "FotoPerfil" },
            new object[] { "Lucas Martins", "Produtor musical e beatmaker de funk e trap, conhecido por suas batidas inovadoras e colaborações com grandes nomes da cena. Influente na definição de novas tendências.", "https://via.placeholder.com/150/808080/FFFFFF?text=Lucas+M." });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ARTISTAS");
        }
    }
}
