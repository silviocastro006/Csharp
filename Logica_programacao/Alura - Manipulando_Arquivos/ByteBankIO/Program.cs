using System.Text;
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoArquivo,FileMode.OpenOrCreate);
        var buffer = new byte[1024]; //1kb
        fluxoDoArquivo.Write(buffer, 0, 1024);

        EscreverBuffer(buffer);
        Console.ReadLine();

    }

    static void EscreverBuffer(byte[] buffer){

        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer);
        Console.WriteLine(texto);

    }
}