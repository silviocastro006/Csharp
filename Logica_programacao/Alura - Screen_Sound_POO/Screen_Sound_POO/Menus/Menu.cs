using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class Menu{

    public void TituloDaOpcao(string titulo){
        int quantidade_letras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidade_letras,'*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos+"\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }

}