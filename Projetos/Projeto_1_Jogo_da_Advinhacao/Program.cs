        Console.WriteLine("--------------------------------");
        Console.WriteLine("Bem vindo ao jogo de adivinhação!");
        Console.WriteLine("--------------------------------");

        do
        {
            Console.WriteLine("\nEscolha a dificuldade: \n(F)ácil \n(M)édio\n(D)ifícil\n(S)air\n");
            char escolha = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (escolha == 'F' || escolha == 'f')
            {
                JogoAdivinhacao(0);
            }
            else if (escolha == 'M' || escolha == 'm')
            {
                JogoAdivinhacao(1);

            }
            else if (escolha == 'D' || escolha == 'd')
            {
                JogoAdivinhacao(2);
            }
            else if (escolha == 'S' || escolha == 's')
            {
                Console.WriteLine("Obrigado por jogar! Até mais!");
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌Opção Inválida, tente novamente❌");
                Console.ResetColor();
            }
            Console.WriteLine();

        } while (true);

    static void JogoAdivinhacao(int indiceDificuldade)
    {
        int[] QuantidadeVidas = { 3, 4, 5 };
        int[] PrimeiroValorPossivel = { 1, 1, 1 };
        int[] UltimoValorPossivel = { 10, 50, 100 };
        int vidasRestantes = QuantidadeVidas[indiceDificuldade];

        Random sorteio = new Random();
        int numeroSorteado = sorteio.Next(PrimeiroValorPossivel[indiceDificuldade], UltimoValorPossivel[indiceDificuldade] + 1);

        if(indiceDificuldade == 0){

            Console.WriteLine("Dificuldade Selecionada: Fácil ");

        }else if(indiceDificuldade == 1){
            Console.WriteLine("Dificuldade Selecionada: Médio");
        }else{
            Console.WriteLine("Dificuldade Selecionada: Difícil");
        }

        Console.WriteLine($"Tente adivinhar um número entre: {PrimeiroValorPossivel[indiceDificuldade]} e {UltimoValorPossivel[indiceDificuldade]}");

        HashSet<int> numeroDigitados = new HashSet<int>();



        while (vidasRestantes > 0)
        {
            Console.WriteLine("Digite um número: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numeroEscolhido))
            {
                if (numeroEscolhido >= PrimeiroValorPossivel[indiceDificuldade] && numeroEscolhido <= UltimoValorPossivel[indiceDificuldade])
                {
                    if(numeroDigitados.Contains(numeroEscolhido)){     //verificação do número que já foi digitado
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Você já digitou esse número , tente novamente!😤");
                        Console.ResetColor();
                        continue;
                    }
                    if (numeroEscolhido == numeroSorteado)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("👑Parabéns!! Você acertou!!!👑");
                        Console.ResetColor();
                        return;
                    }
                    else if (numeroEscolhido > numeroSorteado)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Chute muito alto");
                        vidasRestantes--;
                        Console.WriteLine($"Vidas restantes: {vidasRestantes}");
                        Console.ResetColor();
                    }
                    else if (numeroEscolhido < numeroSorteado)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Chute muito baixo 🥶");
                        vidasRestantes--;
                        Console.WriteLine($"Vidas restantes: {vidasRestantes}");
                        Console.ResetColor();
                    }

                    if (Math.Abs(numeroEscolhido - numeroSorteado) <= 2)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Seu chute está muito próximo!");
                        Console.ResetColor();
                    }
                    else if (Math.Abs(numeroEscolhido - numeroSorteado) >= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Seu chute está muito longe! 🥶🥶");
                    }
                    numeroDigitados.Add(numeroEscolhido); // Aqui ele adiciona a lista de números já digitados 
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"❌Número inválido, escolha números entre: {PrimeiroValorPossivel[indiceDificuldade]} e {UltimoValorPossivel[indiceDificuldade]}.❌");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌Entrada inválida, tente novamente❌");
                Console.ResetColor();
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Você perdeu😡");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"☠ Suas vidas acabaram. O número sorteado era: {numeroSorteado} ☠");
        Console.ResetColor();
    }