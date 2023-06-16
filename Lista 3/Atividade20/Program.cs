Console.WriteLine("Informe o tipo de combustível (A - Álcool, G - Gasolina):");
char tipoCombustivel = char.ToUpper(Console.ReadKey().KeyChar);
Console.WriteLine();

Console.WriteLine("Informe a quantidade de litros vendidos:");
int quantidadeLitros = int.Parse(Console.ReadLine());
Console.WriteLine();

double precoGasolina = 2.50;
double precoAlcool = 1.90;

double valorTotal;

if (tipoCombustivel == 'A')
{
    if (quantidadeLitros <= 20)
    {
        valorTotal = quantidadeLitros * (precoAlcool - (precoAlcool * 0.03));
    }
    else
    {
        valorTotal = quantidadeLitros * (precoAlcool - (precoAlcool * 0.05));
    }
}
else if (tipoCombustivel == 'G')
{
    if (quantidadeLitros <= 20)
    {
        valorTotal = quantidadeLitros * (precoGasolina - (precoGasolina * 0.04));
    }
    else
    {
        valorTotal = quantidadeLitros * (precoGasolina - (precoGasolina * 0.06));
    }
}
else
{
    Console.WriteLine("Tipo de combustível inválido. Digite A para Álcool ou G para Gasolina.");
    return;
}

Console.WriteLine("Valor total a ser pago: R$ " + valorTotal.ToString("F2"));

