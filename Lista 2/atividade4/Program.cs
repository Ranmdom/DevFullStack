/*
Programa que leia a quantidade de dias, horas ,minutos e segundos 
Sendo 1 hora = 3600 segundos 
1 minuto = 60 segundos 
segundo = segundos 
*/
Console.WriteLine("Digite a quantidade de horas que quer saber em minutos: ");
string input_H = Console.ReadLine();

Console.WriteLine("Digite a quantidade de minutos que quer saber em segundos: ");
string input_M = Console.ReadLine();

Console.WriteLine("Digite a quantidade de segundos: ");
string input_S = Console.ReadLine();

//verificação e variaveis 
int horas, minutos ,segundos;

bool sucesso_h = int.TryParse(input_H, out horas);
bool sucesso_m = int.TryParse(input_M, out minutos);
bool sucesso_s = int.TryParse(input_S, out segundos);

if(sucesso_h && sucesso_m && sucesso_s){
    int tempo_h, tempo_M;
    tempo_h = horas * 3600;
    tempo_M = minutos * 60;

    Console.WriteLine("-----------------------------------------");
    Console.WriteLine(horas + " horas em segundos é: " + tempo_h);
    Console.WriteLine(minutos + " minutos em segundos é: " + tempo_M);
    Console.WriteLine(segundos + "segundos em segundos é: " + segundos);
    Console.WriteLine("-----------------------------------------");
}
else{
    Console.WriteLine("Entrada inválida, por favor digite apenas números inteiros");
}
