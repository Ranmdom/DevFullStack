Console.WriteLine("Digite uma sequência de números separados por espaço: ");
        string entrada = Console.ReadLine();

        string[] numeros = entrada.Split(' ');

        int quantidadePares = 0;
        int quantidadeImpares = 0;

        foreach (string numeroStr in numeros)
        {
            int numero = int.Parse(numeroStr);

            if (numero % 2 == 0)
            {
                quantidadePares++;
            }
            else
            {
                quantidadeImpares++;
            }
        }

        Console.WriteLine("Quantidade de números pares: {0}", quantidadePares);
        Console.WriteLine("Quantidade de números ímpares: {0}", quantidadeImpares);
    