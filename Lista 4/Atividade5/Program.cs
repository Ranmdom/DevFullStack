int quantidadeNumeros = 5;
        int maiorNumero = int.MinValue;

        for (int i = 1; i <= quantidadeNumeros; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > maiorNumero)
            {
                maiorNumero = numero;
            }
        }

        Console.WriteLine($"O maior número digitado é: {maiorNumero}");
