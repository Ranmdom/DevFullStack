Console.Write("Quantos números você deseja digitar? ");
        int quantidade = int.Parse(Console.ReadLine());

        int menor = int.MaxValue;
        int maior = int.MinValue;
        int soma = 0;

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            int numero = int.Parse(Console.ReadLine());

            if (numero < menor)
            {
                menor = numero;
            }

            if (numero > maior)
            {
                maior = numero;
            }

            soma += numero;
        }

        Console.WriteLine("Menor valor: " + menor);
        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Soma dos valores: " + soma);
