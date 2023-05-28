/*
Programa que peça o valor e mostre se é positivo ou negativo
*/
Console.WriteLine("Digite um valor: ");
int valor = int.Parse(Console.ReadLine());

if(valor >= 0){
    Console.WriteLine("O valor: " + valor + " é positivo");
}
else{
    Console.WriteLine("O valor " + valor + " é negativo");
}