Console.WriteLine("Digite um número inteiro de 1 a 10: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 1 && numero <= 10)
        {
            Console.WriteLine("Tabuada do número {0}:", numero);

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado);
            }
        }
        else
        {
            Console.WriteLine("Número inválido. Digite um número inteiro de 1 a 10.");
        }