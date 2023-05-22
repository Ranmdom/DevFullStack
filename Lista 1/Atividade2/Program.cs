// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um número: ");
string input = Console.ReadLine();


int numero;
//Converter o string em número inteiro
//Verificação se é um numero inteiro ou não 
bool  sucesso = int.TryParse(input, out numero);
if(sucesso){
    int dobro = numero * 2; 
    Console.WriteLine("O dobro do número digitado é: " + dobro);
}
else{
    Console.WriteLine("Entrada incorreta, Só é possível digitar números inteiros");
}








