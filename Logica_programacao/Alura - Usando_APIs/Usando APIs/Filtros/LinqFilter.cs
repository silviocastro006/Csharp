using System.Linq;
using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {   
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();

        Console.WriteLine($"Todos os gêneros musicais da API");

        foreach(var genero in todosOsGenerosMusicais){
            Console.WriteLine($"- {genero}");
        }
    }


    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero){

        var ArtistasFiltradosPorGeneroMusicas = musicas.Where(musicas => musicas.Genero!.Contains(genero)).Select(musicas => musicas.Artista).Distinct().ToList();

        Console.WriteLine($"Artistas do gênero {genero}");

        foreach(var artista in ArtistasFiltradosPorGeneroMusicas){
            Console.WriteLine($" - {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista){

        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(artista)).ToList();

        foreach(var musica in musicasDoArtista){
            Console.WriteLine($" - {musica.Nome}");
            
        }
    }


    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tom){

        var musicasPorTom = musicas.Where(musicas => musicas.chave == Array.IndexOf(musicas.tonalidades,tom)).ToList();

        foreach(var musica in musicasPorTom){
            musica.ExibirDetalhesDaMusica();
            Console.WriteLine("========================================");
        }
    }
}