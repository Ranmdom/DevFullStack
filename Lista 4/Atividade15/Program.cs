        int a = 1;
        int b = 1;

        Console.WriteLine("Série de Fibonacci:");

        Console.Write(a + " ");
        Console.Write(b + " ");

        int c = 0;

        while (c < 500)
        {
            c = a + b;

            if (c >= 500)
                break;

            Console.Write(c + " ");

            a = b;
            b = c;
        }