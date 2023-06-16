
Console.WriteLine("Hello, World!");

        double[] vetor = new double[10];

        // Preenchendo o vetor
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o número real {0}: ", i + 1);
            vetor[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Vetor na ordem inversa:");

        // Exibindo o vetor na ordem inversa
        for (int i = 9; i >= 0; i--)
        {
            Console.WriteLine(vetor[i]);
        }
