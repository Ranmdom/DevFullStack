Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        int fatorial = 1;

        for (int i = numero; i >= 1; i--)
        {
            fatorial *= i;
        }

        Console.WriteLine(numero + "! = " + fatorial);