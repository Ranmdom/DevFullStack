Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = VerificarPrimo(numero);

        if (ehPrimo)
        {
            Console.WriteLine("{0} é um número primo.", numero);
        }
        else
        {
            Console.WriteLine("{0} não é um número primo.", numero);
        }
    

    static bool VerificarPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }