/*
Programa que leia 2 numeros e perguntar ao usuário se ele quer realizar qual operação 
Adição, subtração, multiplicação ou divisão
*/
Console.WriteLine("Informe o primeiro número: ");
float numero = float.Parse(Console.ReadLine());
Console.WriteLine("Informe o segundo número: ");
float numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("Qual Operação deseja fazer:");
Console.WriteLine("1 - Adição");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("Obs: Digite o numero que queria fazer a operação");
string operacao = Console.ReadLine();

float resultado = 0;
//Operações: 
if(operacao == "1"){
     resultado = numero + numero2;

}else if(operacao == "2"){
    resultado = numero - numero2;

}else if(operacao == "3"){
    resultado = numero * numero2;

}else if(operacao == "4"){
    resultado = numero / numero2;
}else{
    Console.WriteLine("Entrada inválida");
}

Console.WriteLine("Resultado: " + resultado);

//Par ou ímpar

if(resultado % 2 == 0){
    Console.WriteLine("O resultado é par");
}else{
    Console.WriteLine("O resultado é ímpar");
}

//Positivo ou negativo 
if(resultado >= 0){
    Console.WriteLine("O resultado é positivo");

}else{
    Console.WriteLine("O resultado é negativo");
}

//Inteiro ou decimal 
if(resultado % 1 == 0){
    Console.WriteLine("O resultado é inteiro");
}else{
    Console.WriteLine("O resultado é decimal");
}