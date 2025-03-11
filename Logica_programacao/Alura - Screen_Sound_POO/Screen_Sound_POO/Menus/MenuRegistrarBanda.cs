using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        TituloDaOpcao("Registro das Bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada!");
        bandasRegistradas.Add(nomeDaBanda, banda);
        Thread.Sleep(2000);
        Console.Clear();
    }
}