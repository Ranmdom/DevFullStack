Console.WriteLine("Escolha o tipo de carne:");
Console.WriteLine("1 - Filé Duplo");
Console.WriteLine("2 - Alcatra");
Console.WriteLine("3 - Picanha");
Console.WriteLine();
int opcaoCarne = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade em kg:");
double quantidade = double.Parse(Console.ReadLine());
Console.WriteLine();

double preco;

if (quantidade <= 5)
{
    switch (opcaoCarne)
    {
        case 1:
            preco = 4.90;
            break;
        case 2:
            preco = 5.90;
            break;
        case 3:
            preco = 6.90;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            return;
    }
}
else
{
    switch (opcaoCarne)
    {
        case 1:
            preco = 5.80;
            break;
        case 2:
            preco = 6.80;
            break;
        case 3:
            preco = 7.80;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            return;
    }
}

double valorTotal = quantidade * preco;

Console.WriteLine("Pagamento no cartão Tabajara (S/N)?");
string opcaoCartao = Console.ReadLine();
Console.WriteLine();

if (opcaoCartao.ToUpper() == "S")
{
    valorTotal *= 0.95; // Aplica desconto de 5%
}

Console.WriteLine("Valor total a ser pago: R$ " + valorTotal.ToString("F2"));

