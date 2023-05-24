
/*
Programa que pergunte o quanto ganha por hora 
E mostre o números de horas trabalhadas no mês
Calular e mostrar o total do salário no referido mês

salario = quantidade que ganhar por hora * quantidade de hora que trabalha
*/
Console.WriteLine("Informe o mês que está trabalhando: ");
string input_M = Console.ReadLine();

Console.WriteLine("Informe quantas horas você trabalhou durante o mês: ");
string input_H = Console.ReadLine();

Console.WriteLine("Digite quanto ganha por hora: ");
string input_D = Console.ReadLine();

float salario, horas_trab, Qt_horas;
string mês;

bool sucesso_h = float.TryParse(input_H, out horas_trab);
bool sucesso_Qt = float.TryParse(input_D, out Qt_horas);

if(sucesso_h && sucesso_Qt){
    salario = horas_trab * Qt_horas;

    Console.WriteLine("--------------------------------------------------------------------------------------");
    Console.WriteLine("No mês de " + input_M + " com " + horas_trab + " horas seu salario é de " + salario+" reais");
    Console.WriteLine("---------------------------------------------------------------------------------------");
}
