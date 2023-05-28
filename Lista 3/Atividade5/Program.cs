/*
Programa que leia três números e mostre o maior deles
Apenas números diferentes
*/ 
Console.WriteLine("Digite o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o terceiro número: ");
int numero3 = int.Parse(Console.ReadLine());

int maior = 0;

//Verificar se o número é diferente

if(numero1 != numero2 && numero1 != numero3 && numero2 != numero3){
     if(numero1 > maior){
        maior = numero1;
     }

    if(numero2 > maior){
        maior = numero2;
    }
    if(numero3 > maior){
        maior = numero3;
    }

    Console.WriteLine("O maior número é: " + maior);

}
else{
    Console.WriteLine("Apenas números diferentes");
}