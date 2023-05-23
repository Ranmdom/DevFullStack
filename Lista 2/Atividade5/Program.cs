/*
Programa de calcular tempo de viagem 
Precisando de velocidade média ( VM ) e distancia em (KM)
tempo = km / vm 
*/

Console.WriteLine("Qual a distência que vai percorrer: ");
string input_D = Console.ReadLine();

Console.WriteLine("Qual a velocidade média: ");
string input_V = Console.ReadLine();

float KM, VM,tempo; 

bool sucesso_D = float.TryParse(input_D, out KM);
bool sucesso_V = float.TryParse(input_V, out VM);

if(sucesso_D && sucesso_V){
    tempo = VM / KM;
    //calculo para transformar em minutos 
    tempo = tempo * 100;

    Console.WriteLine("O tempo de viagem será de: " + tempo + " minutos");

}
