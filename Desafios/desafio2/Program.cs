//Programa para ler uma temperatura em graus para fahrenheit 
Console.WriteLine("Digite a quantidade do valor em graus: ");
string input = Console.ReadLine();

float graus;
bool sucesso = float.TryParse(input, out graus);
if(sucesso){
//Formula C/5 = F - 32 / 9 ou seja multiplicar por 1.8 e somar 32. 
  float F = (graus * 1.8f) + 32;

  Console.WriteLine("A temperatura em Fahrenheit é: " + F);
}
else{
    Console.WriteLine("Entradad inválida, por favor digite apenas números");
}



