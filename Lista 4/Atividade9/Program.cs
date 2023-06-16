Console.WriteLine("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Números no intervalo entre {0} e {1}:", numero1, numero2);

        int menor = Math.Min(numero1, numero2);
        int maior = Math.Max(numero1, numero2);
        int soma = 0;

        for (int i = menor + 1; i < maior; i++)
        {
            Console.WriteLine(i);
            soma += i;
        }

        Console.WriteLine("Soma dos números: {0}", soma);
