Console.Write("Digite um número inteiro (N): ");
        int n = int.Parse(Console.ReadLine());

        int countDivisoes = 0;

        Console.WriteLine("Números primos entre 1 e {0}:", n);

        for (int i = 2; i <= n; i++)
        {
            bool ehPrimo = true;

            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                countDivisoes++;

                if (i % j == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }

            if (ehPrimo)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Número de divisões realizadas: {0}", countDivisoes);