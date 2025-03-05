namespace  ScreenSound.Modelos;

internal class Banda : IAvaliavel
{

    public List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public double Media {
        get{
            if(notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public string Nome { get; }

    public Banda(string nome)
    {
        Nome = nome;
    }

    public void AdicionarAlbum(Album album){
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota){
        notas.Add(nota);
    }

    public void ExibirDiscografia(){

        Console.WriteLine($"Discografia da banca {Nome}");

        foreach(var album in albuns){
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}