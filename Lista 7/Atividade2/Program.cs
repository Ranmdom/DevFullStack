using System;
using Atividade2;

TV minhaTV = new TV();

Console.WriteLine("Ligando....");
Console.WriteLine("Bem vindo(a) a sua TV!");

while(true){
    Console.WriteLine("Escolha uma das opções: \nOpção: \n 1 - Mudar De Canal \n 2 - Aumentar Volume \n 3 - Diminuir Volume \n 4 - Desligar TV\n");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Sua opção: ");
    char opcao = Console.ReadKey().KeyChar;
    Console.ResetColor();

    switch(opcao){
        case '1': 
        Console.Write("\nEscolha o canal(1 - 100): ");
        int novoCanal = int.Parse(Console.ReadLine());
        minhaTV.MudarCanal(novoCanal);
        break;

        case '2':
        minhaTV.AumentarVolume();
        break;

        case '3':
        minhaTV.DiminuirVolume();
        break;

        case '4':
        //Encerra a aplicação
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nDesligando.....");
        Console.ResetColor();
        Environment.Exit(0);
        break;

        default:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nOpção inválida, por favor escolha uma das opções válidas");
        Console.ResetColor();
        break;
    }
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\nCanal Atual: {minhaTV.CanalAtual}");
    Console.ResetColor();
}
