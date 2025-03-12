using System;
using NPOI;
using DesafioConsulta.Consulta;
using DesafioConsulta.Medico;
using NPOI.SS.UserModel;
using System.Text.RegularExpressions;

class Program
    {
        private static List<Consulta> consultas = new List<Consulta>();
        private static string caminho = Path.Combine(Environment.CurrentDirectory,"DesafioMedicos.xlsx");

        static void Main(string[] args)
        {
            ImportarPlanilha();
            Exercicio01();
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
            
            var atendimentosDia = consultas
                                  .Where(x => x.DataConsulta.Day >= 27 && x.DataConsulta.Day <= 31)
                                  .OrderBy(x => x.NomePaciente)
                                  .ThenBy(x => x.DataConsulta)
                                  .Select(x => new{
                                    nomePaciente = x.NomePaciente,
                                    dataConsulta = x.DataConsulta.Date
                                  })
                                  .ToList();

            foreach (var atendimento in atendimentosDia)
            {
                Console.WriteLine($"Nome: {atendimento.nomePaciente, -30} | Data Consulta: {atendimento.dataConsulta:dd/MM/yyyy}");
            }
        }
    }