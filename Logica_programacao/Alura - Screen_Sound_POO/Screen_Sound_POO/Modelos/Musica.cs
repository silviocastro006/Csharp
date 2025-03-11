using System;
namespace  ScreenSound.Modelos;

internal class Musica{
    
    public string Nome { get; }
    public string Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public Musica(string artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }



    public void ExibirFichaTecnica(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel){
            Console.WriteLine("Disponível no plano.");
        } else {
            Console.WriteLine("Aquira o plano Plus+");
        }
        
    }

}