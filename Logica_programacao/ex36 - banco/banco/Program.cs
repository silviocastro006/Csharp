using System;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("========== ABERTURA DE C.C. NO BANCOVESTIDO =============");
        Console.Write("Titular: ");
        string tit = Console.ReadLine();
        Console.Write("Número de identificação: ");
        int id = int.Parse(Console.ReadLine());
        Conta conta = new Conta(tit, id);
        Menu();
    }

    public void Menu(){
        
        Console.WriteLine("01)");
        
    }
}