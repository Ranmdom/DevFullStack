 char[] vetor = new char[10];
        int quantidadeConsoantes = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º caractere: ");
            vetor[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Consoantes lidas:");

        for (int i = 0; i < 10; i++)
        {
            if (EhConsoante(vetor[i]))
            {
                Console.WriteLine(vetor[i]);
                quantidadeConsoantes++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Foram lidas {quantidadeConsoantes} consoantes.");
    

    static bool EhConsoante(char caractere)
    {
        char[] consoantes = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z',
                              'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

        return Array.IndexOf(consoantes, caractere) >= 0;
    }