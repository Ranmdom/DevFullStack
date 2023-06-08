/*
Faça um programa que pergunte em que turno você estuda. 
Digitar M ,V ou N  , M = Matutino , N = Noturno, V = Vespertino
Imprimir a mensagem "Bom dia", "Boa tarde", "Boa noite"
*/
Console.WriteLine("Digite qual o seu turno: ");
Console.WriteLine("M - Matutino");
Console.WriteLine("V - Vespertino");
Console.WriteLine("N - Noturno");

string turno = Console.ReadLine();

if(turno == "M" || turno == "m"){
    Console.WriteLine("Bom dia");
}
else if(turno == "V" || turno == "v"){
     Console.WriteLine("Boa tarde");
}
else if(turno == "N" || turno == "n"){
    Console.WriteLine("Boa noite");
}
else{
    Console.WriteLine("Opção inválida, por favor digite apenas as entradas listadas acima");
    
}