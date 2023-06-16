int tamanhoVetor = 100;
        int[] vetor = new int[tamanhoVetor];
        int numero = 1;
        int contador = 0;

        while (contador < tamanhoVetor)
        {
            if (numero % 7 != 0)
            {
                vetor[contador] = numero;
                contador++;
            }
            numero++;
        }

        Console.WriteLine("Vetor com os 100 primeiros números naturais que não são múltiplos de 7:");

        for (int i = 0; i < tamanhoVetor; i++)
        {
            Console.Write(vetor[i] + " ");
        }
