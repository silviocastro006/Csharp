﻿using System;
using System.Globalization;
using System.Xml;
using System.Xml.Xsl;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using Resolucao.Model;
namespace Resolucao.Main;


internal class Program
{
    // Determinamos o diretório onde está o arquivo
    private static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory,"Funcionarios.xlsx");
    
    // Lista de objetos
    private static List<Funcionario> funcionarios = [];

    static void Main(string[] args)
    {            
        ImportarDadosPlanilha();
        //Exercicio01();
        //Exercicio02();
        //Exercicio03();
        //Exercicio04();
        //Exercicio05();
        //Exercicio06();
        Exercicio07();

    }



    private static void ImportarDadosPlanilha()
    {
        try{

            // Iworkbook é a abstração para uma pasta de trabalho em excel
            // WorkbookFactory é uma fábrica de objetos, ou seja, pega uma planilha, transforma em objeto, verificando se é
            // xls ou xlsx com seus métodos e particularidades
            IWorkbook pastaTrabalho = WorkbookFactory.Create(caminhoArquivo);

            // Acesso a primeira aba contendo a planilha
            ISheet planilha = pastaTrabalho.GetSheetAt(0);

            // Loop para percorrer as linhas da planilha
            for(int i = 1; i < planilha.PhysicalNumberOfRows; i++){
                IRow linha = planilha.GetRow(i);

                string id = linha.GetCell(0).StringCellValue;
                string nome = linha.GetCell(1).StringCellValue;
                string cargo = linha.GetCell(2).StringCellValue;
                string departamento = linha.GetCell(3).StringCellValue;
                DateTime dataAdmissao = linha.GetCell(4).DateCellValue ?? DateTime.Now;
                decimal salario = (decimal) linha.GetCell(5).NumericCellValue;
                string cidade = linha.GetCell(6).StringCellValue;
                string estado = linha.GetCell(7).StringCellValue;

                // Instaciamos o objeto 
                Funcionario funcionario = new (id, nome, cargo, departamento, dataAdmissao, salario, cidade, estado);

                // Adicionamos na lista
                funcionarios.Add(funcionario);

            }
        } catch(Exception e){
            Console.WriteLine(e.Message);
        }
        

    }
#region
    // private static void Exercicio01()
    // {
    //     var nomes = funcionarios.Select(x => x.Nome);
    //     var quantidade = nomes.Distinct().Count();

    //     Console.WriteLine($"A quantidade de funcionários com nomes distindos é {quantidade}");

    //     var quantidade2 = funcionarios.DistinctBy(x => x.Nome).Count();

    //     Console.WriteLine($"A quantidade de funcionários com nomes distindos é {quantidade} (tipo 2)");
    // }

    // private static void Exercicio02()
    // {
    //     var funcionariosOrdenados = funcionarios.OrderBy(x => x.Nome).ThenBy(x => x.Cargo);
        
    //     foreach(var funcionario in funcionariosOrdenados){
    //         Console.WriteLine(funcionario.Nome+" "+funcionario.Cargo);
    //     }


    // }

    // private static void Exercicio03()
    // {
    //     var funcionariosAgrupados = funcionarios
    //                                 .GroupBy(x => x.Departamento)
    //                                 .Select(g => new{
    //                                     Departamento = g.Key,
    //                                     Quantidade = g.Count()
    //                                 });

    //     foreach(var departamento in funcionariosAgrupados){
    //         Console.WriteLine($"{departamento.Departamento} - {departamento.Quantidade}");
    //     }

    // }

    // private static void Exercicio04()
    // {
    //     var media = funcionarios.Average(x => x.Salario);
    //     Console.WriteLine($"Média salarial {media}");

    //     var media2 = funcionarios
    //                 .Select(x => x.Salario).Average();

    //     Console.WriteLine($"Média 2: {media2}");
    // }

    // private static void Exercicio05()
    // {
    //     var funcionariosComMaiorSalario = funcionarios
    //                     .OrderByDescending(x => x.Salario)
    //                     .Take(5)
    //                     .ToList();

    //     for(int i = 0; i < funcionariosComMaiorSalario.Count(); i++){
    //         Console.WriteLine($"{i+1} Lugar = {funcionariosComMaiorSalario[i].Nome} - {funcionariosComMaiorSalario[i].Salario:C}");
    //     }
    // }

    // private static void Exercicio06()
    // {
    //     var maiorSalariosMedios = funcionarios
    //                     .GroupBy(x => x.Departamento)
    //                     .Select(g => new {
    //                         departamento = g.Key,
    //                         salario = g.Average(f => f.Salario)
    //                     })
    //                     .OrderByDescending(x => x.salario)
    //                     .Take(3)
    //                     .ToList();
        
    //     Console.WriteLine("============== TOP 3 SALARIOS MEDIOS ================");
    //     foreach(var funcionario in maiorSalariosMedios){

    //         Console.WriteLine($"{funcionario.departamento} --> {funcionario.salario:C}");
    //     }
    // }

    // private static void Exercicio07(){
        
    //     var quantidadeAdmissoes = funcionarios.Select(x => x.DataAdmissao);

    //     foreach(var admissoes in quantidadeAdmissoes){
    //         Console.WriteLine($"{admissoes.Month}/{admissoes.Year}");
    //     }
    // }
#endregion

    private static void Exercicio01(){

        // filtrar a lista para pegar os nomes
        var nomes = funcionarios.Select(x => x.Nome);
        var quantidadeFuncionarios = nomes.Distinct().Count();

        Console.WriteLine($"A quantidade de nomes distintos na empresa é de {quantidadeFuncionarios}.");


        //
    }

    private static void Exercicio02()
    {
        var funcionariosPeloNome = funcionarios.OrderBy(x => x.Nome).ThenBy(y => y.Cargo).Select(filtro => new{
            nome = filtro.Nome,
            cargo = filtro.Cargo
        }).ToList();

        foreach (var funcionario in funcionariosPeloNome)
        {
            Console.WriteLine($"{funcionario.nome} - {funcionario.cargo}");
        }
    }

    private static void Exercicio03()
    {
        var grupo = funcionarios
                    .GroupBy(x => x.Departamento)
                    .Select(y => new{
                        Departamento = y.Key,
                        Quantidade = y.Count()
                    });

        foreach (var funcionario in grupo)
        {
            Console.WriteLine($"{funcionario.Departamento} = {funcionario.Quantidade}");
        }
    }

    private static void Exercicio04()
    {
        var salarioMedio = funcionarios.Select(x => x.Salario).Average();

        Console.WriteLine($"O salário médio da empresa é de R$ {salarioMedio:C}");
    }

    private static void Exercicio05()
    {
        var topCincoFuncionarios = funcionarios.OrderBy(x => x.Salario).Select(y => new{
            nome = y.Nome,
            salario = y.Salario,
        }).Take(5);

        var lugar = 1;
        foreach (var top in topCincoFuncionarios)
        {
            Console.WriteLine($"{top.nome,-20} - {top.salario, -10:C} - Nº {lugar, -5}");
            lugar++;
        }
    }

    private static void Exercicio06()
    {
        var Top3departamentoSalarioMedio = funcionarios
                                           .GroupBy(x => x.Departamento)
                                           .Select(x => new{
                                            chave = x.Key,
                                            salario = x.Average(x => x.Salario)
                                           })
                                            .OrderByDescending(x => x.salario)
                                            .Take(3)
                                            .ToList();

        int c = 1;
        foreach (var grupo in Top3departamentoSalarioMedio)
        {
            Console.WriteLine($"Departamento: {grupo.chave, -20} | Salario médio: R$ {grupo.salario, -10:C} | TOP {c}");
            c++;
        }
    }

    private static void Exercicio07()
    {
        var admissoesPorMes = funcionarios
                            .GroupBy(x => x.DataAdmissao.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper())
                            .Select(y => new{
                                mes = y.Key,
                                quantidade = y.Count()
                            })
                            .OrderBy(w => DateTime.ParseExact(w.mes, "MMMM", new CultureInfo("pt-BR")).Month);

        foreach (var admi in admissoesPorMes)
        {
            Console.WriteLine($"{admi.mes, -15} : {admi.quantidade}");
        }
    }
}

