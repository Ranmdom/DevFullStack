/*
Programa para calcular a redução de tempo de vida de um fumante 
1- Quantidade de cigarros que ele fuma por dia 
2 - 1 cigarro = 10 min de vida perdida 
24h = 1440 minutos 
mostrar a quantidade de vida ele perderá 
*/
Console.WriteLine("Digite a quantidade cigarros que fuma por dia: ");
string input_C = Console.ReadLine();

int cigarros_dia, tempo_de_fumo, vida_perdida;

bool sucesso_C = int.TryParse(input_C, out cigarros_dia);
if(sucesso_C = true){
    tempo_de_fumo = cigarros_dia * 10;
    vida_perdida = tempo_de_fumo / 1440;
    Console.WriteLine("Você perdeu " +vida_perdida+ " dias de vida fumando cigarro");

}

