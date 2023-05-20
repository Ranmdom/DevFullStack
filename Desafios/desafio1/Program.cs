//Programa de dias, horas ,minutos e segundos e é para calcular em segundos. 
/*
Dias em segundos = Um dia tem 86400 segundos ,então é só fazer dias * 86400
Horas em segundos =  1 hora tem 3600 segundos  = hora * 3600
Minutos em segundos =  1 minuto tem 60 segundos = minuto * 60
*/
Console.WriteLine("Escreva a opção desejada: Dias, Horas ou Minutos \npara transformar em segundos: ");
string opcao = Console.ReadLine();

if(opcao == "Dias"){
    Console.WriteLine("informe a quantidade de dias que quer saber em segundos: ");
    string dias = Console.ReadLine();
    int Qt_dia,segundos; 
    int.TryParse(dias, out Qt_dia);
    segundos = Qt_dia * 86400;
    Console.WriteLine(Qt_dia + " dias em segundos é: " + segundos + " segundos ");

}else if(opcao == "Horas"){
    Console.WriteLine("Informe a quantidade de horas que quer saber em segundos: ");
    string horas = Console.ReadLine();
    int Qt_hora, segundos; 
    int.TryParse(horas, out Qt_hora);
    segundos = Qt_hora * 3600;
    Console.WriteLine(Qt_hora + " de horas em segundos é: " + segundos + " segundos ");

}else if(opcao == "Minutos"){
    Console.WriteLine("Informe a quantidade de minutos que deseja saber em segundos: ");
    string minutos = Console.ReadLine();
    int Qt_minuto,segundos; 
    int.TryParse(minutos, out Qt_minuto);
    segundos = Qt_minuto * 60; 
    Console.WriteLine(Qt_minuto + " de minutos em segundos é: " + segundos + " segundos ");
}
else{
    Console.WriteLine("Opção inválida! Por favor digite corretamente");
}
