using System.Text.Json;
using ScreenSound.Modelos;
using ScreenSound.Filtros;

using (HttpClient cliente = new HttpClient())

try
{
    
    {
        string resposta = await cliente.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

    }

}
catch (Exception ex)
{
    Console.WriteLine($"Temos um problema {ex}");
    
}