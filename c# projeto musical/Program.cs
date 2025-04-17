string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string>{"Charlie Brown Jr", "Nirvana", "Calipso"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Charlie Brown Jr", new List<int> {10, 9, 8});
bandasRegistradas.Add("Nirvana", new List<int> ());

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
        case 3: AvaliarUmaBanda();
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
     ExibirTituloNaTela("REGISTRO DE BANDAS.");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirNomesDasBandas()
{
    Console.Clear();
    ExibirTituloNaTela("BANDAS FAVORITAS");
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string listaDasBandasFinal in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {listaDasBandasFinal}");
    }
    Console.WriteLine("\nDigite qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void ExibirTituloNaTela(string titulo)
 {
    int quantidadeDeNumeros = titulo.Length;
    string asteristico = string.Empty.PadLeft(quantidadeDeNumeros, '*');
    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico + "\n");
 }

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloNaTela("AVALIAÇÃO DE BANDAS.");
    Console.Write("Escolha uma banda para avaliar: ");
    string bandaEscolhida = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        Console.Write($"Qual nota você acha que a banda {bandaEscolhida} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[bandaEscolhida].Add(nota);
        Console.WriteLine("Nota atribuida com sucesso");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    } else 
    {
        Console.WriteLine($"\nBanda {bandaEscolhida} não foi encontrada.");
        Console.WriteLine("Digite qualquer tecla para retornar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();