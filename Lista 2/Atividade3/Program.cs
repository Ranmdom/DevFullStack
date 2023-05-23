/*
Programa que calcula a área do quadrado, e depois mostrar o dobro da area 
Area = b.h ou b.b; 
*/

Console.WriteLine("Digite o lado do quadrado: ");
string input = Console.ReadLine();

float area,lado; 
bool sucesso_A = float.TryParse(input , out lado);

if(sucesso_A = true){
    area = lado * lado;

    Console.WriteLine("A área do quadrado é: " + area + " m2");
    Console.WriteLine("O dobro da sua área é: " + area * 2 + " m2"); 
}
else{
    Console.WriteLine("Entrada inválida ,por favor digite apenas números");
}

