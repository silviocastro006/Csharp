using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        TituloDaOpcao("Avaliar Banda");
        Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine();

        if(bandasRegistradas.ContainsKey(nomeDaBanda)){
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }else{
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}