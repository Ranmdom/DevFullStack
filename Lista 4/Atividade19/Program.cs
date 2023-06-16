Console.Write("Quantos números você deseja digitar? ");
        int quantidade = int.Parse(Console.ReadLine());

        int menor = 1001;
        int maior = -1;
        int soma = 0;

        for (int i = 0; i < quantidade; i++)
        {
            int numero;

            do
            {
                Console.Write("Digite o número {0} (entre 0 e 1000): ", i + 1);
                numero = int.Parse(Console.ReadLine());

                if (numero < 0 || numero > 1000)
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            }
            while (numero < 0 || numero > 1000);

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