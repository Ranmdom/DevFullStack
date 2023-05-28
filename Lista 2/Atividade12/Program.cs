/*
Salario fixo + 5% (0.05) do valro das vendas. 
Algoritmo que leia o numero de carros por ele vendidos, o valor do carro e o salário fixo
Calcule e escreva o salário final do vendedor
*/
Console.WriteLine("Informe a quantidade de carros vendidos: ");
float carros_Vendas = float.Parse(Console.ReadLine()); 
Console.WriteLine("Informe o valor do carro: ");
float carro_valor = float.Parse(Console.ReadLine());
Console.WriteLine("Infore o salário fixo: ");
float salario_fixo =float.Parse(Console.ReadLine());

float valor_vendas = carros_Vendas * carro_valor;

float salario_final = salario_fixo + (valor_vendas * 0.05f);

Console.WriteLine("O salario Final do vendedor no mês é: " + salario_final + " Reais");
