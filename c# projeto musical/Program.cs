string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void ExibirTextoNaTela()
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
        case 1: Console.WriteLine("Você escolheu a opção: " + opcaoNumericaEscolhida);
        break;
        case 2: Console.WriteLine("Você escolheu a opção: " + opcaoNumericaEscolhida);
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

ExibirTextoNaTela();
ExibirOpcoesDoMenu();