using System;
using System.Globalization;
using NPOI;
using NPOI.SS.UserModel;
using DesafioMusica.Models.Musica;
using NPOI.SS.Formula.Functions;

namespace DesafioMusica.Principal;

class Program
{
    private static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "musicas.xlsx");

    private static List<Musica> musicas = new List<Musica>();



    static void Main(string[] args)
    {
        ImportarDados();
        //Exercicio01();
        //Exercicio02();
        //Exercicio03();
        //Exercicio04();
        //Exercicio05();
        Exercicio06();
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

    public static void Exercicio02()
    {
        var artistasUnicos = musicas.DistinctBy(x => x.Artista).Count();
        Console.WriteLine($"No total temos {artistasUnicos} artistas únicos");
    }

    public static void Exercicio03()
    {
        var lancamentoAlbuns = musicas
                               .GroupBy(x => new{
                                    mes = x.DataLancamento.Date.Month,
                                    ano = x.DataLancamento.Date.Year
                               })
                               .Select(x => new{
                                    data = new DateTime(x.Key.ano,x.Key.mes,1),
                                    quantidade = x.Select(y => y.DataLancamento).Count()
                               })
                               .OrderBy(x => x.data.Year)
                               .ThenBy(x => x.data.Month);


        foreach (var lancamento in lancamentoAlbuns)
        {
            Console.WriteLine($"{lancamento.data.ToString("MMMM").ToUpper(),-10}{"/",-5}{lancamento.data.ToString("yyyy"),-10}: {lancamento.quantidade, 5}");
        }

        
    }

    public static void Exercicio04()
    {
        
        Console.WriteLine("=============================     A     ================================\n");

        var generoComMaisMusicas = musicas
                                   .GroupBy(x => x.Genero)
                                   .Select(x => new{
                                        nome = x.Key,
                                        quantidade = x.Count()
                                   })
                                   .OrderByDescending(x => x.quantidade)
                                   .Take(5);
                                   

        int posicao = 1;

        foreach (var coiso in generoComMaisMusicas)
        {
            Console.WriteLine($"{posicao, -4}º Lugar: {coiso.nome, -25} - {coiso.quantidade, -5} musicas");
            posicao++;
        }

        Console.WriteLine("=============================     B     ================================\n");


        var albunsComMaisMusicas = musicas
                                   .GroupBy(x => x.Album)
                                   .Select(x => new{
                                        nome = x.Key,
                                        quantidade_Musicas = x.Select(y => y.Nome).Count()
                                   })
                                   .OrderByDescending(x => x.quantidade_Musicas)
                                   .Take(3);
                                   

        int top = 1;
        foreach (var coiso in albunsComMaisMusicas)
        {
            Console.WriteLine($"{top, -4}º Lugar: {coiso.nome, -25} - {coiso.quantidade_Musicas, -5} musicas");
            top++;
        }

            Console.WriteLine("=============================     C     ================================\n");


        var paisesComMaisMusicas =  musicas
                                    .GroupBy(x => x.Pais)
                                    .Select(x => new{
                                            nome_pais = x.Key,
                                            quantidade_Musicas = x.Select(y => y.Nome).Count()
                                    })
                                    .OrderByDescending(x => x.quantidade_Musicas)
                                    .Take(5);
                                   

        int topy = 1;
        foreach (var coiso in paisesComMaisMusicas)
        {
            Console.WriteLine($"{topy, -4}º Lugar: {coiso.nome_pais, -25} - {coiso.quantidade_Musicas, -5} musicas");
            topy++;
        }               

        
    }

    public static void Exercicio05()
    {   
        var GravadorasComMaisMusicas = musicas
                                       .GroupBy(x => x.Gravadora)
                                       .Select(x => new{
                                            nome_gravadora = x.Key,
                                            quantidade_Musicas = x.Select(y => y.Gravadora).Count()
                                       })
                                       .OrderByDescending(x => x.quantidade_Musicas);
                                   

        int top = 1;

        Console.WriteLine($"No total temos {GravadorasComMaisMusicas.CountBy(x => x.nome_gravadora).Count()} gravadoras");

        foreach (var coiso in GravadorasComMaisMusicas)
        {
            Console.WriteLine($"{top, -4}º Lugar: {coiso.nome_gravadora, -25} - {coiso.quantidade_Musicas, -5} musicas");
            top++;
        }
    }

     public static void Exercicio06()
    {   
        // var IdiomaComMaisMusicas = musicas
        //                           .GroupBy(x => new{
        //                                 mes = x.DataLancamento.Date.Month,
        //                                 ano = x.DataLancamento.Date.Year,
        //                                 idioma = x.Idioma
        //                           })
        //                           .Select(x => new{
        //                                 data = new DateTime(x.Key.ano,x.Key.mes,1),
        //                                 quantidade = x.Select(y => y.Idioma).Count()
        //                            })
        //                           .OrderByDescending(x => x.data.Year)
        //                           .ThenByDescending(x => x.data.Month)
        //                           .ThenByDescending(x => x.quantidade)
        //                           .Select(x => new{
                                        
        //                            })
                                  
        
        // foreach (var lancamento in IdiomaComMaisMusicas)
        // {
        //     Console.WriteLine($"{lancamento.data.ToString("MMMM").ToUpper(),-10}{"/",-5}{lancamento.data.ToString("yyyy"),-10}: {lancamento.quantidade, 5}");
        // }
                                   


        
        
    }
}