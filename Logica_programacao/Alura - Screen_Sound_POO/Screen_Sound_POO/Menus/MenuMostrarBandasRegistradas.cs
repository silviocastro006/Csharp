using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuMostrarBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        TituloDaOpcao("Exibindo bandas registradas");

        foreach(string banda in bandasRegistradas.Keys){
            Console.WriteLine($"Banda: {banda}");
        }

        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}