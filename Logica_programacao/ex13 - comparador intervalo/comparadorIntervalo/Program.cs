using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> numeros = new List<float>();
            int dentro = 0;
            int fora = 0;

            bool resp = false;

            while(!resp){
                Console.Write("Digite um número ou 999 para sair: ");
                float num = float.Parse(Console.ReadLine());
                if(num == 999){
                    break;
                }
                if(num>=10 && num<=20){
                    dentro++;
                } else{
                    fora++;
                }

            }

            Console.WriteLine("Quantidade dentro do intervalo: "+dentro);
            Console.Write("Números: ");
            foreach(float numero in numeros){
                if(numero>=10 && numero <= 20){
                    Console.Write(numero+" ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Quantidade fora do intervalo: "+fora);
            Console.Write("Números: ");
            foreach(float numero in numeros){
                if(numero<10 && numero>20){
                    Console.Write(numero+" ");
                }
            }
        }
    }
}