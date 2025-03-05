using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        TituloDaOpcao("Avaliar Album");
        Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine();

        if(bandasRegistradas.ContainsKey(nomeDaBanda)){
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o título do album: ");
            string tituloAlbum = Console.ReadLine();
            if(banda.albuns.Count > 0)
            {   
                Album album = banda.albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o album {tituloAlbum} merece?: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                
                album.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso para o album {tituloAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            }else{
                Console.WriteLine($"O álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            
        }else{
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
         
    }
}