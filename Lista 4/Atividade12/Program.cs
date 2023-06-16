Console.WriteLine("Digite a base: ");
        int baseNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        int resultado = CalcularPotencia(baseNum, expoente);

        Console.WriteLine("{0} elevado a {1} é igual a {2}", baseNum, expoente, resultado);
    

    static int CalcularPotencia(int baseNum, int expoente)
    {
        int resultado = 1;

        for (int i = 1; i <= expoente; i++)
        {
            resultado *= baseNum;
        }

        return resultado;
    }
