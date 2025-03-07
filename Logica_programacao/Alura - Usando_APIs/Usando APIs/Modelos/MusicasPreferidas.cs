using System.Text.Json;

namespace ScreenSound.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListasDeMusicasFavoritas;

    public MusicasPreferidas(string nome){
        Nome = nome;
        ListasDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListasDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavortias()
    {
        Console.WriteLine("========== LISTA DE MUSICAS FAVORITAS ==========");
        foreach(var musica in ListasDeMusicasFavoritas){
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new {
            nome = Nome,
            musicas = ListasDeMusicasFavoritas
        });
        
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo,json);
        Console.WriteLine($"O arquivo json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}