Console.WriteLine("Digite o número de termos da série Fibonacci a serem gerados: ");
        int n = int.Parse(Console.ReadLine());

        int a = 1;
        int b = 1;

        Console.WriteLine("Série de Fibonacci:");

        Console.Write(a + " ");
        Console.Write(b + " ");

        for (int i = 3; i <= n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");

            a = b;
            b = c;
        }