int[] A = new int[10];

        // Preenchendo o vetor com os números digitados pelo usuário
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o número {0}: ", i + 1);
            A[i] = Convert.ToInt32(Console.ReadLine());
        }

        int somaQuadrados = 0;

        // Calculando a soma dos quadrados dos elementos do vetor
        for (int i = 0; i < 10; i++)
        {
            somaQuadrados += A[i] * A[i];
        }

        Console.WriteLine("A soma dos quadrados dos elementos do vetor é: " + somaQuadrados);
