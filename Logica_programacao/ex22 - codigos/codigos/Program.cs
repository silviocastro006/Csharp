using System;

    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("============= ABASTECIMENTO ==============");
            Console.WriteLine("1 ) Alcool");
            Console.WriteLine("2 ) Gasolina");
            Console.WriteLine("3 ) Diesel");
            Console.WriteLine("4 ) Sair");
            Console.Write("Opção desejada: ");
            int op = int.Parse(Console.ReadLine());

            while(op <1 || op > 4){
                Console.Write("Opção inválida, digite uma das opções acima: ");
                op = int.Parse(Console.ReadLine());
            }

            while(op!=4){
                
                switch(op){
                    case 1: 
                        alcool+=1;
                        break;
                    case 2:
                    gasolina+=1;
                        break;
                    case 3:
                    diesel+=1;
                        break;
                }

                Console.Write("Opção desejada: ");
                op = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {alcool}");

                
            
        }
    }