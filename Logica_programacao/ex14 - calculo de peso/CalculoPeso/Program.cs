using System;
using System.Net.Mail;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("================ Calculo de Peso ===============");
            Console.Write("Quantidade de valores: ");
            int quant = int.Parse(Console.ReadLine());

            // Estruturas para armazenar os vaores
            Dictionary<int, List<double>> valores = new Dictionary<int, List<double>>();
            List<double> medias = new List<double>();

            for(int i = 0; i<quant; i++){

                valores[i] = new List<double>();

                for(int j = 0; j < 3; j++){

                    Console.Write($"{j+1}º valor: ");
                    double valor = double.Parse(Console.ReadLine());
                    valores[i].Add(valor);

                }
                
                
            }
            
            // Percorrer as listas para calcular a média
            foreach(List<double> valor in valores.Values){

                double v1 = valor[0] * 2;
                double v2 = valor[1] * 3;
                double v3 = valor[2] * 5;

                double media = (v1+v2+v3)/3;

                medias.Add(media);
            }

            // Mostrar os valores na tela
            Console.Clear();
            Console.WriteLine("================= RESULTADOS ==================");
            Console.WriteLine($"Ciclos: {quant}");
            for(int i = 0; i<quant; i++){
                Console.WriteLine($"========== {i+1}º Ciclo ============");

                foreach(double valor in valores[i]){
                    Console.Write($"{valor} ");
                }
                Console.Write($" = {medias[i]}");
                Console.WriteLine();
            }
            
            
            

        }

        
            
    }
}
