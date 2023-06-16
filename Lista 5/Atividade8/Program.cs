        string[] sistemasOperacionais = { "Windows Server", "Unix", "Linux", "NetWare", "Mac OS", "Outro" };
        int[] votos = new int[6];
        int totalVotos = 0;

        while (true)
        {
            Console.WriteLine("Qual o melhor sistema operacional para uso em servidores?");
            Console.WriteLine("1 - Windows Server");
            Console.WriteLine("2 - Unix");
            Console.WriteLine("3 - Linux");
            Console.WriteLine("4 - NetWare");
            Console.WriteLine("5 - Mac OS");
            Console.WriteLine("6 - Outro");
            Console.WriteLine("0 - Encerrar a enquete");

            Console.Write("Digite o número correspondente à sua escolha: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 0)
                break;

            if (opcao < 1 || opcao > 6)
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 6 ou 0 para encerrar.");
                continue;
            }

            votos[opcao - 1]++;
            totalVotos++;
        }

        Console.WriteLine();
        Console.WriteLine("Sistema Operacional | Votos | %");
        Console.WriteLine("-------------------|-------|----");

        for (int i = 0; i < sistemasOperacionais.Length; i++)
        {
            int percentual = (int)Math.Round((double)votos[i] / totalVotos * 100);
            Console.WriteLine($"{sistemasOperacionais[i],-19} | {votos[i],5} | {percentual,2}%");
        }

        Console.WriteLine("-------------------|-------|----");
        Console.WriteLine($"Total               | {totalVotos,5} |");

        int indiceVencedor = Array.IndexOf(votos, votos.Max());
        Console.WriteLine($"Sistema operacional mais votado foi o {sistemasOperacionais[indiceVencedor]}. Com {votos[indiceVencedor]} votos,");
        Console.WriteLine($"correspondendo a {Math.Round((double)votos[indiceVencedor] / totalVotos * 100)}% dos votos.");
