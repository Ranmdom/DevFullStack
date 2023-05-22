//Pedir a entrada em metros
Console.WriteLine("Digite o número em metros: ");
string input = Console.ReadLine();
//Metros para centrimétros = 1 m x 100 
float metros; 
float.TryParse(input, out metros);

float centrimetos = metros * 100;
Console.WriteLine(metros + " metros em centrimetos é: " + centrimetos + " Centrimetros");