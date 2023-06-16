        int quantidadeAlunos = 30;
        int contador = 0;
        int somaIdades = 0;
        double somaAlturas = 0;

        // Declaração dos vetores de idades e alturas
        int[] idades = new int[quantidadeAlunos];
        double[] alturas = new double[quantidadeAlunos];

        // Preenchimento dos vetores de idades e alturas
        for (int i = 0; i < quantidadeAlunos; i++)
        {
            Console.Write("Digite a idade do aluno {0}: ", i + 1);
            idades[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura do aluno {0} em metros: ", i + 1);
            alturas[i] = Convert.ToDouble(Console.ReadLine());

            somaIdades += idades[i];
            somaAlturas += alturas[i];
        }

        double mediaAlturas = somaAlturas / quantidadeAlunos;
        
        // Verificação da quantidade de alunos com mais de 13 anos e altura inferior à média
        for (int i = 0; i < quantidadeAlunos; i++)
        {
            if (idades[i] > 13 && alturas[i] < mediaAlturas)
            {
                contador++;
            }
        }

        Console.WriteLine("Quantidade de alunos com mais de 13 anos e altura inferior à média: " + contador);
