    using System;
    using System.Data.Common;

    namespace Program
    {
        class Program
        {
            static void Main(string[] args)
            {

                Dictionary<int, List<float>> valores = new Dictionary<int, List<float>>();
                List<string> resultado = new List<string>();


                Console.WriteLine("============== Teste de divisão ============");
                Console.Write("Quantos ciclos deseja?: ");
                int quant  = int.Parse(Console.ReadLine());

                for(int i = 0; i < quant; i++){

                    valores[i] = new List<float>();

                    Console.WriteLine($"================ CICLO Nº {i+1} =============");
        
                    float v1 = float.Parse(Console.ReadLine());
                    float v2 = float.Parse(Console.ReadLine());

                    valores[i].Add(v1);
                    valores[i].Add(v2);

                    if(v2 == 0){
                        resultado.Add("divisão impossível");
                    } else {
                        resultado.Add((v1/v2).ToString());
                    }

                    Console.Clear();

                }

                Console.Clear();

                Console.WriteLine("================ DIVISÃO DE VALORES =============");

                for(int i = 0; i <  valores.Count(); i++){

                    Console.WriteLine($"==================== {i+1} CICLO =====================");

                    List<float> resultados_string = valores[i];

                    for(int j = 0; j < resultados_string.Count(); j++){
                        
                        Console.Write($"{resultados_string[j]} ");

                        if(j == 0){
                            Console.Write(" / ");
                        }
                        
                    }
                    Console.WriteLine($" = {resultado[i]}");

                }

            }

        }
    }