string opcao;
        do
        {
            Console.Write("Digite um número inteiro positivo menor que 16: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero < 16)
            {
                int fatorial = 1;

                for (int i = numero; i >= 1; i--)
                {
                    fatorial *= i;
                }

                Console.WriteLine(numero + "! = " + fatorial);
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, digite um número inteiro positivo menor que 16.");
            }

            Console.WriteLine("Deseja calcular o fatorial de outro número? (S/N)");
            opcao = Console.ReadLine();
        }
        while (opcao.ToUpper() == "S");