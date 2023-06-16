Console.WriteLine("Informe a quantidade de morangos em kg:");
double quantidadeMorangos = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Informe a quantidade de maçãs em kg:");
double quantidadeMacas = double.Parse(Console.ReadLine());
Console.WriteLine();

double precoMorango;
double precoMaca;

if (quantidadeMorangos <= 5)
{
    precoMorango = 2.50;
}
else
{
    precoMorango = 2.20;
}

if (quantidadeMacas <= 5)
{
    precoMaca = 1.80;
}
else
{
    precoMaca = 1.50;
}

double valorTotal = (quantidadeMorangos * precoMorango) + (quantidadeMacas * precoMaca);

if (quantidadeMorangos + quantidadeMacas > 8 || valorTotal > 25.00)
{
    valorTotal *= 0.90; // Aplica desconto de 10%
}

Console.WriteLine("Valor total a ser pago: R$ " + valorTotal.ToString("F2"));

