Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10,8,6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo(){
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░██████╗░███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝██████╔╝█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══██╗██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║██║░░██║███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
Console.WriteLine("Boas vindas ao Screen Sound!");
}

void Menu(){
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao){
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4: 
            ExibirMediaBanda();
            break;
        case -1:
            break;
    }
}

void RegistrarBanda(){
    Console.Clear();
    TituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada!");
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    TituloDaOpcao("Exibindo bandas registradas");

    foreach(string banda in bandasRegistradas.Keys){
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void TituloDaOpcao(string titulo){
    
    int quantidade_letras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidade_letras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos+"\n");

}

void AvaliarUmaBanda(){
    Console.Clear();
    TituloDaOpcao("Avaliar Banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine();

    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece?: ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        Menu();
    }else{
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}


void ExibirMediaBanda(){
    Console.Clear();
    TituloDaOpcao("Avaliar Banda");
    Console.WriteLine("Digite o nome da banda que deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine();
    
    if(bandasRegistradas.ContainsKey(nomeDaBanda)){
        
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Digite uma tecla para voltar ao menu inicial");
        Console.ReadKey();
        Console.Clear();
        Menu();

    }else{
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        Menu();
    }
}




Menu();
