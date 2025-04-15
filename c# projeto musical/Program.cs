string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>{"Charlie Brown Jr", "Nirvana", "Calipso"};
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("Digite a opção escolhida:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumericaEscolhida = int.Parse(opcaoEscolhida);
    
    
    switch (opcaoNumericaEscolhida) 
    {
        case 1: RegistrarBanda();
        break;
        case 2: ExibirNomesDasBandas();
        break;
        case 3: Console.WriteLine("Você escolheu a opção: " + opcaoNumericaEscolhida);
        break;
        case 4: Console.WriteLine("Você escolheu a opção: " + opcaoNumericaEscolhida);
        break;
        case -1: Console.WriteLine("Bye Bye *");
        break;
        default : Console.WriteLine("Opção inválida!");
        break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("\n*********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*********************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirNomesDasBandas()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Lista de bandas:");
    Console.WriteLine("*********************\n");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string listaDasBandasFinal in listaDasBandas)
    {
        Console.WriteLine($"Banda: {listaDasBandasFinal}");
    }
    Console.WriteLine("\nDigite qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}


ExibirOpcoesDoMenu();