/*
programa que peça dois numeros inteiros ( int ) e um numero real (double) e em seguida ele calcule o produto do dobro do primeiro e metade do segundo 
2- A soma do triplo do primeiro com o tercerio 
3- o terceiro elevado ao cubo 
*/
Console.WriteLine("Digite o primeiro número: ");
string input = Console.ReadLine();

Console.WriteLine("Digite o segundo número: ");
string input2 = Console.ReadLine();

Console.WriteLine("Digite o terceiro número: ");
string input3 = Console.ReadLine();

int num1, num2;
double num3, resultado1,resultado2,resultado3; 

bool sucesso_n1 = int.TryParse(input, out num1);
bool sucesso_n2 = int.TryParse(input2, out num2);
bool sucesso_n3 = double.TryParse(input3, out num3);

if(sucesso_n1 && sucesso_n2 && sucesso_n3){
    resultado1 = ((2 * num1) * (num2 / 2));
    resultado2 = (3 * num1) + num3;
    resultado3 = Math.Pow(num3, 3);
    Console.WriteLine("+-----------------------------------------------------------------+");
    Console.WriteLine("+Produto do dobro do primeiro com metade do segundo: " + resultado1);
    Console.WriteLine("+A soma do triplo do primeiro como o terceiro: " + resultado2);
    Console.WriteLine("+O terceiro elevado ao cubo: " + resultado3);
    Console.WriteLine("+-----------------------------------------------------------------+");

}

