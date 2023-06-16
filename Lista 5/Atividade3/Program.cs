 int[] numeros = new int[20];
        int[] par = new int[20]; // Vetor para armazenar os números pares
        int[] impar = new int[20]; // Vetor para armazenar os números ímpares

        // Preenchendo o vetor com os números digitados pelo usuário
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int contadorPar = 0;
        int contadorImpar = 0;

        // Separando os números pares e ímpares nos respectivos vetores
        for (int i = 0; i < 20; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                par[contadorPar] = numeros[i];
                contadorPar++;
            }
            else
            {
                impar[contadorImpar] = numeros[i];
                contadorImpar++;
            }
        }

        Console.WriteLine("Números digitados: ");
        ImprimirVetor(numeros);

        Console.WriteLine("Números pares: ");
        ImprimirVetor(par, contadorPar);

        Console.WriteLine("Números ímpares: ");
        ImprimirVetor(impar, contadorImpar);

    static void ImprimirVetor(int[] vetor, int tamanho = 20)
    {
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(vetor[i]);
        }
        Console.WriteLine();
    }
