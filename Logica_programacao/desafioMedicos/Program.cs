using System;
using NPOI;
using DesafioConsulta.Consulta;
using DesafioConsulta.Medico;
using NPOI.SS.UserModel;
using System.Text.RegularExpressions;
using SixLabors.ImageSharp.ColorSpaces;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Org.BouncyCastle.Security;

class Program
    {
        private static List<Consulta> consultas = new List<Consulta>();
        private static string caminho = Path.Combine(Environment.CurrentDirectory,"DesafioMedicos.xlsx");

        private static List<Medico> medicos = new List<Medico>();

        static void Main(string[] args)
        {
            ImportarPlanilha();
            Exercicio01();
            Exercicio02();
            Exercicio03();
            Exercicio04();
            Exercicio05();
        }

        public static void ImportarPlanilha(){

            
            
            IWorkbook pastaTrabalho = WorkbookFactory.Create(caminho);
            ISheet planilha = pastaTrabalho.GetSheetAt(0);

            // Iteração

            for (int i = 1; i < planilha.PhysicalNumberOfRows; i++)
            {
                IRow linha = planilha.GetRow(i);

                DateTime DataConsulta = DateTime.Parse(linha.GetCell(0).StringCellValue).Date;
                string HoraDaConsulta = linha.GetCell(1).StringCellValue;
                string NomePaciente = linha.GetCell(2).StringCellValue;
                string NumeroTelefone = linha.GetCell(3)?.StringCellValue;
                long Cpf = long.Parse(Regex.Replace(linha.GetCell(4).StringCellValue,@"\D",""));
                string Rua = linha.GetCell(5).StringCellValue;
                string Cidade = linha.GetCell(6).StringCellValue;
                string Estado = linha.GetCell(7).StringCellValue;
                string Especialidade = linha.GetCell(8).StringCellValue;
                string NomeMedico = linha.GetCell(9).StringCellValue;
                bool Particular = linha.GetCell(10).StringCellValue == "Sim"?true:false;
                long NumeroDaCarteirinha = (long) linha.GetCell(11).NumericCellValue;
                double ValorConsulta =(double) linha.GetCell(12).NumericCellValue;

                Consulta consulta = new Consulta(DataConsulta, HoraDaConsulta, NomePaciente, NumeroTelefone, Cpf, Rua, Cidade, Estado, Especialidade, NomeMedico, Particular, NumeroDaCarteirinha, ValorConsulta);

                consultas.Add(consulta);

            }

        }

        public static void Exercicio01(){
            
            var pacientesAtendidos = consultas
                                     .Where(x => x.DataConsulta.Day >= 27 && x.DataConsulta.Day <= 31)
                                     .OrderBy(x => x.DataConsulta)
                                     .ThenBy(x => x.NomePaciente)
                                     .GroupBy(x=> x.NomePaciente)
                                     .Select(x => new{
                                        nome = x.Key
                                     });

            var filtro2 = consultas
                          .Where(x => x.DataConsulta.Day >= 27 && x.DataConsulta.Day <= 31)
                          .Select(x => new{
                            nome = x.NomePaciente
                          })
                          .DistinctBy(x => x.nome);
                                     

            foreach (var grupo in pacientesAtendidos)
            {
                Console.WriteLine($"Nome: {grupo.nome}");
            }

            Console.WriteLine($"Total de pacientes entre 27 e 31 é de: {pacientesAtendidos.Count()}");

            foreach (var nome in filtro2)
            {
                Console.WriteLine($"Nome: {nome.nome}");
            }

            Console.WriteLine($"Total de pacientes entre 27 e 31 é de: {pacientesAtendidos.Count()}");

        }
    
        public static void Exercicio02()
        {
            var medicosNome = consultas.DistinctBy(x => x.NomeMedico);

            foreach (var medico in medicosNome)
            {
                Console.WriteLine($"Dr. {medico.NomeMedico}");
            }

            Console.WriteLine($"O total de médicos é de: {medicosNome.Count()}");
        }
    
        // public static void Exercicio03()
        // {

        //     var listaOrdenadaPorNomeMedico = consultas.OrderBy(x => x.NomeMedico);
           
        //     string ultimoNome = "";

        //     foreach (var linha in consultas)
        //     {   
        //         string nome = linha.NomeMedico;
        //         string especialidade = linha.Especialidade;
        //         List<string> especialidades = new List<string>();

        //         if(nome.Equals(ultimoNome))
        //         {
        //             if(especialidades.Count() == 0) continue;

        //             foreach (var pessoa in medicos)
        //             {
        //                 if(pessoa.Especialidades.Contains(especialidade))
        //                 {
        //                     continue;
        //                 } else {
        //                     pessoa.Especialidades.Add(especialidade);
        //                     continue;
        //                 }
        //             }
        //         }
                
        //         ultimoNome = nome;
        //         especialidades.Add(especialidade);
        //         Medico medico = new Medico(nome,especialidades);
        //         medicos.Add(medico);  

        //     }


        //     foreach (var medico in medicos)
        //     {
        //         Console.Write($"Nome: {medico.NomeMedico}: ");
        //         foreach (var especialidade in medico.Especialidades)
        //         {
        //             Console.WriteLine($"{especialidade}");
        //         }
        //         Console.WriteLine("");
        //     }
        // }
    
        public static void Exercicio03()
        {
            var MedicoEspecialidades = consultas
                                       .GroupBy(x => x.NomeMedico)
                                       .Select(y => new{
                                            nome = y.Key,
                                            especialidades = y.Select(z => z.Especialidade).Distinct()
                                       });

            foreach (var medico in MedicoEspecialidades)
            {
                Console.WriteLine($"Dr. {medico.nome} : {string.Join(",",medico.especialidades)}");
            }

        }
    
        public static void Exercicio04()
        {
                var ValorTotalConsultas = consultas.Sum(x => x.ValorConsulta);

                var ValorTotalPorEspecialidade = consultas
                                                 .GroupBy(x => x.Especialidade)
                                                 .Select(y => new{
                                                    nome = y.Key,
                                                    valor = y.Sum(x => x.ValorConsulta)
                                                 });

                Console.WriteLine($"{"Especialidades",-20}{"|",-5}{"Valor Total",-10}");
                foreach (var especialidade in ValorTotalPorEspecialidade)
                {
                    Console.WriteLine($"{especialidade.nome,-20}{"|",-5}{especialidade.valor,-10:C}");
                }

                Console.WriteLine($"Valor total das consultas: {ValorTotalConsultas:C}");
        }

        public static void Exercicio05()
        {
            
            var consultasFiltradas = consultas.Where(d => d.DataConsulta.Day == 30);
 
            var consultaParticular = consultasFiltradas.Count(x => x.Particular);
            var consultaConvenio = consultasFiltradas.Count(x => !x.Particular);
 
            Console.WriteLine($"Total:{consultasFiltradas.Count()} | Particular: {consultaParticular} | Convênio: {consultaConvenio}");

            var FiltroConsultasPorDia1 = consultas
                                        .Where(x => x.DataConsulta.Day == 30)
                                        .Select(x => new {
                                            nome = x.NomeMedico,
                                            especialidade = x.Especialidade,
                                            horario = x.HoraDaConsulta
                                        })
                                        .OrderBy(x => x.nome)
                                        .ThenBy(x => x.horario);

            var FiltroConsultasPorDia2 = consultas
                                         .Where(x => x.DataConsulta.Day == 30)
                                         .GroupBy(x => x.NomeMedico)
                                         .Select(x => new{
                                            nome = x.Key,
                                            especialidade = x.Select(x => x.Especialidade.ToString()).Distinct(),
                                            horarios = x.Select( x => x.HoraDaConsulta).Distinct()
                                         });



            foreach (var coiso in FiltroConsultasPorDia1)
            {
                Console.WriteLine($"{coiso.nome, -20}|{coiso.horario, -5}|{coiso.especialidade, -20}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
             Console.WriteLine($"\n{"NOME MEDICO", -25} | {"ESPECIALIDADE", -40} | {"HORARIOS", -20}");
            foreach (var coiso in FiltroConsultasPorDia2)
            {
                Console.WriteLine($"{coiso.nome, -25} - {string.Join(",",coiso.especialidade), -40} : {string.Join(", ",coiso.horarios), -20}");
            }
            
        }
}