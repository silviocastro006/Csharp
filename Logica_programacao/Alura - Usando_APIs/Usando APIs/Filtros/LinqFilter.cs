using System.Linq;
using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {   
        var todosOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais){
            Console.WriteLine($"- {genero}");
        }
    }
}