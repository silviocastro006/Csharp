using System;
using System.Globalization;
using NPOI;
using NPOI.SS.UserModel;
using DesafioMusica.Models.Musica;

namespace DesafioMusica.Principal;

class Program
{
    private static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "musicas.xlsx");

    private static List<Musica> musicas = new List<Musica>();



    static void Main(string[] args)
    {
        ImportarDados();
        Exercicio01();
    }


    public static void ImportarDados()
    {
        try
        {
            IWorkbook pasta = WorkbookFactory.Create(caminhoArquivo);
    
            ISheet planilha = pasta.GetSheetAt(0);
    
            for (int i = 1; i < planilha.PhysicalNumberOfRows; i++)
            {
                IRow linha = planilha.GetRow(i);
    
                int codigo = (int) linha.GetCell(0).NumericCellValue;
                DateTime dataLancamento = linha.GetCell(1).DateCellValue ?? DateTime.MinValue;
                string nome = linha.GetCell(2).StringCellValue;
                string artista = linha.GetCell(3).StringCellValue;
                string album = linha.GetCell(4).StringCellValue;
                string genero = linha.GetCell(5).StringCellValue;
                double duracao = (double) linha.GetCell(6).NumericCellValue;
                string gravadora = linha.GetCell(7).StringCellValue;
                string pais = linha.GetCell(8).StringCellValue;
                string idioma = linha.GetCell(9).StringCellValue;
    
                Musica musica = new Musica(codigo, dataLancamento, nome, artista, album, genero, duracao, gravadora, pais, idioma);

                musicas.Add(musica);
    
                }
        }
        catch (System.Exception)
        {
            
            throw new ArgumentException("Erro ao tentar importar planilha!");
        }

        }

    public static void Exercicio01()
    {
        var maiorDuracao = musicas.MaxBy(x => x.Duracao);
        Console.WriteLine($"A maior duração é a {maiorDuracao.Nome} de {maiorDuracao.Duracao:F2} minutos");
    }


}