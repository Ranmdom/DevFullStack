using System;
using System.Linq;
using System.Text;

public class JogoDaForca
{
    private static string[] palavras = { "carro", "banana", "abobora", "casa", "compras", "amarelo" };
    private static Random sorteio = new Random();

    private static string[] forca = {
        "  +------+" +
        "\n|      |" +
        "\n|       " +
        "\n|       " +
        "\n|       " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|       " +
        "\n|       " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|      | " +
        "\n|       " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|     /| " +
        "\n|       " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|     /|\\" +
        "\n|       " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|     /|\\" +
        "\n|     /  " +
        "\n|       " +
        "==========",

        "  +------+" +
        "\n|      |" +
        "\n|      O " +
        "\n|     /|\\" +
        "\n|     / \\" +
        "\n|       " +
        "=========="
    };

    public static void Main(string[] args)
    {
        Console.WriteLine("+============================+");
        Console.WriteLine("+ Bem-vindo ao Jogo da Forca +");
        Console.WriteLine("+============================+");

        do
        {
            Console.WriteLine("\nPressione qualquer tecla para começar a jogar!");
            Console.WriteLine("\nPara sair pressione a tecla 'S'");
            char tecla = Console.ReadKey().KeyChar;
            Console.Clear();

            if (tecla == 'S' || tecla == 's')
            {
                Console.WriteLine("Obrigado por jogar! Até mais!");
                break;
            }

            Jogar();

        } while (true);
    }

    private static string SortearPalavra()
    {
        int indiceSorteado = sorteio.Next(0, palavras.Length);
        return palavras[indiceSorteado];
    }

    private static string ObterPalabraEscondida(char[] letrasAcertadas)
    {
        return new string(letrasAcertadas.Select(letra => letra == '\0' ? '_' : letra).ToArray());
    }

    private static void Jogar()
    {
        string palavraSorteada = SortearPalavra();
        char[] letrasAcertadas = new char[palavraSorteada.Length];
        StringBuilder letrasUtilizadas = new StringBuilder();
        int vidas = 6;
        int letrasDescobertas = 0;

        do
        {
            Console.WriteLine(forca[vidas]);
            Console.WriteLine("\nPalavra: " + ObterPalabraEscondida(letrasAcertadas));
            Console.WriteLine("Vidas: Restantes " + vidas);
            Console.WriteLine("Letras utilizadas: " + letrasUtilizadas.ToString());

            Console.WriteLine("\nDigite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            Console.Clear();

            if (letrasUtilizadas.ToString().Contains(letra))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Letra já utilizada. Tente outra letra.");
                Console.ResetColor();
                continue;
            }

            letrasUtilizadas.Append(letra);

            if (palavraSorteada.Contains(letra))
            {
                for (int i = 0; i < palavraSorteada.Length; i++)
                {
                    if (palavraSorteada[i] == letra && letrasAcertadas[i] == '\0')
                    {
                        letrasAcertadas[i] = letra;
                        letrasDescobertas++;
                    }
                }

                if (letrasDescobertas == palavraSorteada.Length)
                {
                    Console.WriteLine(forca[vidas]);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nParabéns!! Você ganhou!");
                    Console.WriteLine("A palavra era: " + palavraSorteada);
                    Console.ResetColor();
                    break;
                }
            }
            else
            {
                vidas--;

                if (vidas == 6)
                {
                    Console.WriteLine(forca[vidas]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVocê perdeu!");
                    Console.WriteLine("A palavra era: " + palavraSorteada);
                    Console.ResetColor();
                    break;
                }
            }

        } while (true);
    }
}
