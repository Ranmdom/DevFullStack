Console.WriteLine("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Números no intervalo entre {0} e {1}:", numero1, numero2);

        // Verifica qual é o menor número e qual é o maior número
        int menor = Math.Min(numero1, numero2);
        int maior = Math.Max(numero1, numero2);

        // Gera os números no intervalo e os imprime na tela
        for (int i = menor + 1; i < maior; i++)
        {
            Console.WriteLine(i);
        }
