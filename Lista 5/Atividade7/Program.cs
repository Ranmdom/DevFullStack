Console.Write("Digite o nome do atleta: ");
        string nomeAtleta = Console.ReadLine();

        double[] saltos = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite a distância alcançada no {0}º salto: ", i + 1);
            saltos[i] = Convert.ToDouble(Console.ReadLine());
        }

        double media = CalcularMedia(saltos);

        Console.WriteLine("\nResultado final:");
        Console.WriteLine("Atleta: " + nomeAtleta);
        Console.Write("Saltos: ");
        ImprimirVetor(saltos);
        Console.WriteLine("Média dos saltos: " + media.ToString("F1") + " m");


    static double CalcularMedia(double[] vetor)
    {
        double soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        return soma / vetor.Length;
    }

    static void ImprimirVetor(double[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i].ToString("F1") + " - ");
        }
        Console.WriteLine();
    }