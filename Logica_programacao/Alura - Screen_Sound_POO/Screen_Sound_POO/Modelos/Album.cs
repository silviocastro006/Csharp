namespace  ScreenSound.Modelos;

internal class Album : IAvaliavel
{

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public double Media
    {
        get{
            if(notas.Count == 0) return 0;
            else return notas.Average(m => m.Nota);
        }
    }

    public Album(string nome)
        {
            Nome = nome;
        }


    public void AdicionarMusica(Musica musica){
        musicas.Add(musica);
    }

    public void ExibirMusicasdoAlbum(){
        Console.WriteLine($"Lista de músicas do Album {Nome}:");
        foreach(var musica in musicas){
            Console.WriteLine($"Musica: {musica}");
        }
        Console.WriteLine($"Para ouvir este Album inteiro, você precisa de {DuracaoTotal}");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}