        int tamanhoVetor = 10;
        double[] vetor = new double[tamanhoVetor];

        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write("Elemento {0}: ", i + 1);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        OrdenarVetor(vetor);

        Console.WriteLine("\nVetor ordenado:");

        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.WriteLine(vetor[i]);
        }

    static void OrdenarVetor(double[] vetor)
    {
        int tamanhoVetor = vetor.Length;

        for (int i = 0; i < tamanhoVetor - 1; i++)
        {
            for (int j = 0; j < tamanhoVetor - i - 1; j++)
            {
                if (vetor[j] > vetor[j + 1])
                {
                    // Troca os elementos de posição
                    double temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
