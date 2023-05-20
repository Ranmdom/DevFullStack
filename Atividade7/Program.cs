Console.WriteLine("Digite o seu salário: ");
string input = Console.ReadLine();

float salario;
float.TryParse(input, out salario);

float reajuste = salario * 12/100;
float novo_salario = salario + reajuste;

Console.WriteLine("Valor do novo salário com 12% de reajuste: " +novo_salario);

//12% = 12/100 
