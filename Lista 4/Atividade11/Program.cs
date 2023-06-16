Console.WriteLine("Digite um número inteiro para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor inicial da tabuada: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor final da tabuada: ");
        int fim = int.Parse(Console.ReadLine());

        if (fim >= inicio)
        {
            Console.WriteLine("Tabuada do número {0}:", numero);

            for (int i = inicio; i <= fim; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }
        }
        else
        {
            Console.WriteLine("Valor final menor que o valor inicial. Digite um intervalo válido.");
        }
