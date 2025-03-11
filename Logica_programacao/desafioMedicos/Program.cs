using System;
using NPOI;
using DesafioConsulta.Consulta;
using DesafioConsulta.Medico;
using NPOI.SS.UserModel;
using System.Text.RegularExpressions;

class Program
    {
        static void Main(string[] args)
        {
            
        }




        public static void ImportarPlanilha(){

            List<Consulta> consultas = new List<Consulta>();
            string caminho = Path.Combine(Environment.CurrentDirectory,"DesafioMedicos.xlsx");
            IWorkbook pastaTrabalho = WorkbookFactory.Create(caminho);
            ISheet planilha = pastaTrabalho.GetSheetAt(0);

            // Iteração

            for (int i = 1; i <= planilha.PhysicalNumberOfRows; i++)
            {
                IRow linha = planilha.GetRow(i);

                DateTime DataConsulta = DateTime.Parse(linha.GetCell(0).StringCellValue);
                string HoraDaConsulta = linha.GetCell(1).StringCellValue;
                string NomePaciente = linha.GetCell(2).StringCellValue;
                string NumeroTelefone = linha.GetCell(3).StringCellValue;
                long Cpf = Convert.ToInt64(Regex.Replace(linha.GetCell(4).StringCellValue,@"\D",""));
                string Rua = linha.GetCell(5).StringCellValue;
                string Cidade = linha.GetCell(6).StringCellValue;
                string Estado = linha.GetCell(7).StringCellValue;
                string Especialidade = linha.GetCell(8).StringCellValue;
                string NomeMedico = linha.GetCell(9).StringCellValue;
                bool Particular = linha.GetCell(10).BooleanCellValue;
                long NumeroDaCarteirinha = (long) linha.GetCell(11).NumericCellValue;
                double ValorConsulta = linha.GetCell(12).NumericCellValue;

                Consulta consulta = new Consulta(DataConsulta, HoraDaConsulta
NomePaciente
NumeroTelefone
Cpf
Rua
Cidade
Estado
Especialidade
NomeMedico
Particular
NumeroDaCarteirinha
ValorConsulta)
            }

        }
    }