/*
Faça um programa que leia três números e mostre-os em ordem decrescente. 
Não pode ser digitados valores iguais
*/
Console.WriteLine("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o terceiro número: ");
double num3 = double.Parse(Console.ReadLine());

//Validação de números difirentes

if(num1 != num2 && num1 != num3 && num2 != num3){
    //Função para obter o menor numero
    double menor = Math.Min(num1, Math.Min(num2, num3));
    double maior = Math.Max(num1, Math.Max(num2, num3));
    double meio = num1 + num2 + num3 - maior - menor;
    
    Console.Write("Ordem decrescente dos núemros: " + maior + " ," + meio + " ," + menor);
}else{
    Console.WriteLine("Os números são iguais");
}