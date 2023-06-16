int tamanhoVetor = 10;
        int[] vetor = new int[tamanhoVetor];

        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nValores iguais encontrados:");

        for (int i = 0; i < tamanhoVetor - 1; i++)
        {
            for (int j = i + 1; j < tamanhoVetor; j++)
            {
                if (vetor[i] == vetor[j])
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
