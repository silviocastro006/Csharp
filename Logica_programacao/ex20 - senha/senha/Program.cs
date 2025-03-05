using System;

    class Program
    {
        static void Main(string[] args)
        {
          int senha = 2002;

          int valida = int.Parse(Console.ReadLine());   
          while(valida != senha){
            Console.Write("Senha inválida! Tente novamente....: ");
            valida = int.Parse(Console.ReadLine()); 
          }

          Console.Write("Acesso permitido !");
        }
    }