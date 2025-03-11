class Podcast{

    private List<Episodio> episodios = new List<Episodio>();
    
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio){
        episodios.Add(episodio);
    }

    public void ExibirDetalhes(){
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");

        foreach(var episodio in episodios){
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Este podcast possui {TotalEpisodios}");
    }



}