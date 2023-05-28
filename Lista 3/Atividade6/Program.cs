/*
Programa que leia 3 numeros e mostre o maior e o menor deles 
*/
Console.WriteLine("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
double numero3 = double.Parse(Console.ReadLine());

double maior = numero1;
double menor = numero1;

if(numero2 > maior){
    maior = numero2;
}

if(numero3 > maior){
    maior = numero3;
}

if(numero2 < menor){
    menor = numero2;
}
if(numero3 < menor){
    menor = numero3;
}

Console.WriteLine("O maior número é: " + maior);
Console.WriteLine("O menor número é: " + menor);
