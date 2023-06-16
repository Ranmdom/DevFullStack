Console.WriteLine("Escolha o tipo de carne:");
Console.WriteLine("1 - Filé Duplo");
Console.WriteLine("2 - Alcatra");
Console.WriteLine("3 - Picanha");
Console.WriteLine();
int opcaoCarne = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade em kg:");
double quantidade = double.Parse(Console.ReadLine());
Console.WriteLine();

string tipoCarne;
double preco;

switch (opcaoCarne)
{
    case 1:
        tipoCarne = "Filé Duplo";
        preco = quantidade <= 5 ? 4.90 : 5.80;
        break;
    case 2:
        tipoCarne = "Alcatra";
        preco = quantidade <= 5 ? 5.90 : 6.80;
        break;
    case 3:
        tipoCarne = "Picanha";
        preco = quantidade <= 5 ? 6.90 : 7.80;
        break;
    default:
        Console.WriteLine("Opção inválida!");
        return;
}

double valorTotal = quantidade * preco;

Console.WriteLine("Pagamento no cartão Tabajara (S/N)?");
string opcaoCartao = Console.ReadLine();
Console.WriteLine();

double desconto = 0.0;
if (opcaoCartao.ToUpper() == "S")
{
    desconto = valorTotal * 0.05;
    valorTotal -= desconto;
}

Console.WriteLine("CUPOM FISCAL");
Console.WriteLine("Tipo de carne: " + tipoCarne);
Console.WriteLine("Quantidade: " + quantidade + " kg");
Console.WriteLine("Preço total: R$ " + valorTotal.ToString("F2"));
Console.WriteLine("Tipo de pagamento: " + (opcaoCartao.ToUpper() == "S" ? "Cartão Tabajara" : "Outros meios"));
Console.WriteLine("Desconto: R$ " + desconto.ToString("F2"));
Console.WriteLine("Valor a pagar: R$ " + valorTotal.ToString("F2"));

