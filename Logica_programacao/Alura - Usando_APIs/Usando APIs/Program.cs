using System.Text.Json;
using ScreenSound.Modelos;
using ScreenSound.Filtros;

using (HttpClient cliente = new HttpClient())

try
{
    
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "metal");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "M83");

        // var musicasPreferidasdoDaniel = new MusicasPreferidas("Daniel");
        // musicasPreferidasdoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasdoDaniel.AdicionarMusicasFavoritas(musicas[123]);
        // musicasPreferidasdoDaniel.AdicionarMusicasFavoritas(musicas[43]);
        // musicasPreferidasdoDaniel.AdicionarMusicasFavoritas(musicas[645]);
        // musicasPreferidasdoDaniel.AdicionarMusicasFavoritas(musicas[966]);
        // musicasPreferidasdoDaniel.ExibirMusicasFavortias();

        // Console.WriteLine("");

        // var musicasPreferidasDoSilvio = new MusicasPreferidas("Silvio");
        // musicasPreferidasDoSilvio.AdicionarMusicasFavoritas(musicas[1234]);
        // musicasPreferidasDoSilvio.AdicionarMusicasFavoritas(musicas[345]);
        // musicasPreferidasDoSilvio.AdicionarMusicasFavoritas(musicas[236]);
        // musicasPreferidasDoSilvio.AdicionarMusicasFavoritas(musicas[766]);
        // musicasPreferidasDoSilvio.AdicionarMusicasFavoritas(musicas[345]);
        // musicasPreferidasDoSilvio.ExibirMusicasFavortias();
        // musicasPreferidasDoSilvio.GerarArquivoJson();


        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C");
        

        

    }

}
catch (Exception ex)
{
    Console.WriteLine($"Temos um problema {ex}");
    
}